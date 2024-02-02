using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current path {Directory.GetCurrentDirectory()}");
            Directory.CreateDirectory("A");
            Directory.SetCurrentDirectory("A");
            Console.WriteLine($"Current path {Directory.GetCurrentDirectory()}");

            Directory.CreateDirectory("A1");
            Directory.CreateDirectory("A2");

            File.WriteAllText("a.txt", "File a.txt content");
            File.WriteAllText("b.txt", "File a.txt content");

            File.WriteAllText("A1/a1.txt", "File a1.txt content");
            File.WriteAllText("A2/a2.txt", "File a2.txt content");

            // get files from folder A

            string[] fnames = Directory.GetFiles(".","a*.txt",SearchOption.AllDirectories);
            Console.WriteLine($"\n\n List files from folder A");
            foreach( string fname in fnames ) {
                Console.WriteLine($"{Path.GetFileName(fname)} in folder {Path.GetDirectoryName(fname)}");
            }

            string[] dirs = Directory.GetDirectories(".");
            Console.WriteLine($"\n\n List folders from folder A");
            foreach( string fname in dirs )
            {
                Console.WriteLine(Path.GetFileName(fname));
            }
            string path = @"C:\Users\konopelko\Downloads";
            string[] entries = Directory.GetFileSystemEntries(path);
            Console.WriteLine($"-------- {path}");
            Console.OutputEncoding= Encoding.UTF8;
            foreach( string item in entries )
            {
                FileInfo fi = new FileInfo(item);
                string info = "<DIR>";
                if(!fi.Attributes.HasFlag(FileAttributes.Directory))
                {
                    info = fi.Length.ToString();
                }
                Console.WriteLine($"{fi.CreationTime,-22} {fi.Name, -40} {info,-15}");
            }

            path = "B";
            DirectoryInfo di = new DirectoryInfo(path);
            if(!di.Exists)
            {
                di.Create();
            }
            di.Attributes = FileAttributes.Directory;
            Console.WriteLine($"\n\nAttributtes B :: {di.Attributes}");
            File.WriteAllText("B/b1.txt","Hello from b1.txt");
            File.WriteAllText("B/b2.txt","Hello from b2.txt");

            FileInfo[] files  = di.GetFiles();
            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name} :: {item.Length} ({item.CreationTime}, {item.FullName})");
            }

        }
    }
}
