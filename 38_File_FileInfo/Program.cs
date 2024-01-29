using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_File_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "Second line" };
            string fname = "../../my.txt";

            if(File.Exists(fname))
            {
                File.Delete(fname);
                Console.WriteLine($"File '{fname}' was deleted\n\n");
            }

            File.AppendAllLines(fname, lines);
            File.AppendAllText(fname, "Third line\nFourth line");

            if (File.Exists(fname))
            {
                File.SetAttributes(fname, FileAttributes.Archive);
            }

            Console.WriteLine($"Attributes :: {File.GetAttributes(fname)}");
            Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");


            string fname2 = "../../copy_my.txt";
            //File.Copy(fname, fname2); exception якщо файл вже існує fname
            File.Copy(fname, fname2,true);
            Console.WriteLine($"\n\nContent of file '{fname2}' \n{File.ReadAllText(fname2)}");


            /*FileStream fs = File.Create("../../test_file.txt");
            fs.WriteByte(65);
            fs.Close();*/

            //var fs = File.AppendText(fname);

            var fs = File.CreateText(fname);
            fs.WriteLine("Write something .... ");
            fs.Close();

            File.AppendAllText(fname, "New line");

            Console.WriteLine($"\n\nContent of file '{fname}' \n{File.ReadAllText(fname)}");

            Console.WriteLine($"Creation time {File.GetCreationTime(fname)}");
            Console.WriteLine($"Last write time {File.GetLastWriteTime(fname)}");


            string fname3 = "../../third.txt";
            FileInfo fi = new FileInfo(fname3);
            Console.WriteLine($"\n\n Is exists file '{fname3}' :: {fi.Exists}");
            if(!fi.Exists)
            {
                using(var tw = fi.CreateText())
                {
                    tw.WriteLine("It is third file");
                }
            }


            // Move
            //fi.MoveTo("./third.txt");
            //fi.MoveTo(Path.Combine(".", fi.Name));
            Console.WriteLine($"Length    :: {fi.Length}");
            Console.WriteLine($"Extension :: {fi.Extension}");
            Console.WriteLine($"GetAttributes :: {File.GetAttributes(fname3)}");
            File.SetAttributes(fname3, FileAttributes.ReadOnly);
            Console.WriteLine($"GetAttributes :: {File.GetAttributes(fname3)}");
        }
    }
}
