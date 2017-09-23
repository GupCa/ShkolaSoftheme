using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApplication_FileRW
{
    public struct FileHandle
    {
        public long FileSize { get; set; }
        public string FileName { get; set; } 
        public string FilePath { get; set; }
        
        [Flags]
        public enum FileAccessEnum
        {
            None = 0,
            Read = 1,
            Write = 2
        }

        public static FileHandle OpenForRead(string filepath)
        {
            long length = new System.IO.FileInfo(filepath).Length;
            string name = new System.IO.FileInfo(filepath).Name;
            string path = new System.IO.FileInfo(filepath).FullName;
            //DirectoryName

            File.Open(filepath, FileMode.Open, FileAccess.Read);
            return new FileHandle
            {
                FileName = name,
                FileSize = length,
                FilePath = filepath,
            };
        }
        
        public static FileHandle OpenForWrite(string filepath)
        {
            long length = new System.IO.FileInfo(filepath).Length;
            string name = new System.IO.FileInfo(filepath).Name;
            string path = new System.IO.FileInfo(filepath).FullName;
            //DirectoryName

            File.Open(filepath, FileMode.Open, FileAccess.Write);
            return new FileHandle
            {
                FileName = name,
                FileSize = length,
                FilePath = filepath,
            };
        }
        
        public static FileHandle OpenFile(string filepath, FileAccessEnum fileAccessEnum)
        {
            if (fileAccessEnum == FileAccessEnum.Read)
                return OpenForRead(filepath);
            
            else if (fileAccessEnum == FileAccessEnum.Write)
                return OpenForWrite(filepath);
            
            else if (fileAccessEnum == (FileAccessEnum.Read | FileAccessEnum.Write))
            {
                long length = new System.IO.FileInfo(filepath).Length;
                string name = new System.IO.FileInfo(filepath).Name;
                string path = new System.IO.FileInfo(filepath).FullName;
                //DirectoryName

                File.Open(filepath, FileMode.Open, FileAccess.ReadWrite);
                return new FileHandle
                {
                    FileName = name,
                    FileSize = length,
                    FilePath = filepath,
                };
            }
            else
            {
                return new FileHandle();
            }
        }
    }
}