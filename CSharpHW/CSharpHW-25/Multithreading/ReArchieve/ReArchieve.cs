using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReArchieve
{
    class ReArchieve
    {
        public void Start(string path)
        {
            if (File.Exists(path) && Path.GetExtension(path).Equals(".zip"))
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
                if (File.Exists(fileName) && Path.GetExtension(fileName).Equals(".zip"))
                {
                    Thread newThread = new Thread(() => ProcessFile(fileName));
                    newThread.Start();
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public void ProcessFile(string pathFile)
        {
            Console.WriteLine("Processed file '{0}'.", pathFile);

            using (ZipArchive zip = ZipFile.Open(pathFile, ZipArchiveMode.Update))
            {
                try
                {
                    zip.ExtractToDirectory(Path.GetDirectoryName(pathFile));
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please rename");
                }
            }
        }
    }
}
