using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    class StringReplaser
    {
        private const string PathToLogFile = "C:\\Users\\Котеночек\\Documents\\test\\log.txt";
        private Object thisLock = new Object();

        public void Start(string path, string toReplace, string thatReplace)
        {

            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                if (Path.GetExtension(fileName) == ".txt" && Path.GetFileName(fileName) != "log.txt")
                {
                    Task task = new Task(() =>
                                        ProcessFile(fileName, toReplace, thatReplace)
                                        );
                    task.Start();

                    Task task2 = task.ContinueWith((Task t) =>
                    {
                        lock (thisLock)
                        {
                            WriteToLog(fileName, toReplace, thatReplace);
                        }
                    });
                }
            }

        }

        public void ProcessFile(string path, string toReplace, string thatReplace)
        {
            string text = File.ReadAllText(path);
            text = text.Replace(toReplace, thatReplace);
            File.WriteAllText(path, text);
        }

        public void WriteToLog(string path, string toReplace, string thatReplace)
        {
            using (StreamWriter sw = File.AppendText(PathToLogFile))
            {
                sw.WriteLine("Name of the file: {0}", Path.GetFileName(path));
                sw.WriteLine("String to replace:{0}", toReplace);
                sw.WriteLine("String that replace:{0}", thatReplace);
                sw.WriteLine("When change:{0}", DateTime.Now);
                sw.WriteLine("---------------------------------");
            }
        }
    }
}
