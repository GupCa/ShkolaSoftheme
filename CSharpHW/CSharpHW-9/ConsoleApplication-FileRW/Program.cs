using System;
using System.Collections.Generic;

namespace ConsoleApplication_FileRW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var filepath = "/Users/vlad/Documents/GitHub/ShkolaSoftheme/CSharpHW/CSharpHW-9/ConsoleApplication-FileRW/test.txt";
            var fileHandle = FileHandle.OpenFile(filepath, FileHandle.FileAccessEnum.Read | FileHandle.FileAccessEnum.Write);
            
            Console.WriteLine("Name: {0}\nPath: {1}\nSize: {2} byte\n", 
                fileHandle.FileName, 
                fileHandle.FilePath, 
                fileHandle.FileSize);
        }
    }
}
