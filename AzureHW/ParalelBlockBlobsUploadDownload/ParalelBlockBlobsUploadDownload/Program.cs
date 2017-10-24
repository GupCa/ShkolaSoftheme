using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.Azure;
using System.IO;
using Microsoft.WindowsAzure.Storage.RetryPolicies;

namespace ParalelBlockBlobsUploadDownload
{
    class Program
    {
        static void Main(string[] args)
        { 
            var MyByte = File.ReadAllBytes("Downloads.7z");
            UploadFileInBlocks(MyByte);

            var ResultsInByte = DownloadFileInBlocks();
            File.WriteAllBytes("WhatDoWeHaveFromAzure.7z", ResultsInByte);
        }

        public static void UploadFileInBlocks(byte[] file)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer cloudBlobContainer = blobClient.GetContainerReference("mycontainer");
            CloudBlockBlob blob = cloudBlobContainer.GetBlockBlobReference("myblob");

            blob.DeleteIfExists();

            List<string> blockIDs = new List<string>();

            int blockSize = 5 * 1024 * 1024;
            long fileSize = file.Length;

            int blockId = 0;

            while (fileSize > 0)
            {
                int blockLength = (int)Math.Min(blockSize, fileSize);

                string blockIdEncoded = GetBase64BlockId(blockId);
                blockIDs.Add(blockIdEncoded);

                byte[] bytesToUpload = new byte[blockLength];
                Array.Copy(file, blockId * blockSize, bytesToUpload, 0, blockLength);

                using (MemoryStream memoryStream = new MemoryStream(bytesToUpload, 0, blockLength))
                {
                    blob.PutBlock(blockIdEncoded, memoryStream, null, null, new BlobRequestOptions
                    {
                        RetryPolicy = new ExponentialRetry(TimeSpan.FromSeconds(2), 1)
                    });
                }

                blockId++;
                fileSize -= blockLength;
            }
            
            blob.PutBlockList(blockIDs);
        }

        public static byte[] DownloadFileInBlocks()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                 CloudConfigurationManager.GetSetting("StorageConnectionString"));

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer cloudBlobContainer = blobClient.GetContainerReference("mycontainer");

            CloudBlockBlob blob = cloudBlobContainer.GetBlockBlobReference("myblob");

            int blockSize = 1024 * 1024; // 1 MB block size

            blob.FetchAttributes();
            long fileSize = blob.Properties.Length;

            byte[] blobContents = new byte[fileSize];
            var positions = new List<int>();
            var i = 0;

            while (i < fileSize)
            { 
                positions.Add(i);
                i += blockSize;
            }

            Parallel.ForEach(positions, position =>
            {
                var blockLength = position + blockSize < fileSize ? blockSize : fileSize - position;

                blob.DownloadRangeToByteArray(blobContents, position, position, blockLength);
            });

            return blobContents;
        }

        private static string GetBase64BlockId(int blockId)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}", blockId.ToString("0000000"))));
        }
    }
}
