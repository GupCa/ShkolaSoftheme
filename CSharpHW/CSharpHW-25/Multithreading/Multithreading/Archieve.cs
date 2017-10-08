using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Multithreading
{
    class Archieve
    {
        public void Start(string path)
        {
            if (File.Exists(path))
            {
                Thread newThread = new Thread(() => ProcessFile(path));
                newThread.Start();
            }
            else if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }
        }

        public void ProcessDirectory(string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                Thread newThread = new Thread(() => ProcessFile(fileName));
                newThread.Start();
            }
            //ProcessFile(fileName);

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public void ProcessFile(string pathFile)
        {
            if (Path.GetExtension(pathFile).Equals(".zip"))
            {
                return;
            }

            Console.WriteLine("Processed file '{0}'.", pathFile);

            var pathArchieve = Path.GetDirectoryName(pathFile) + "\\" + Path.GetFileNameWithoutExtension(pathFile) +
                               ".zip";

            using (ZipArchive zip = ZipFile.Open(pathArchieve, ZipArchiveMode.Update))
            {
                zip.CreateEntryFromFile(pathFile, Path.GetFileName(pathFile));
            }

        }
    }
}