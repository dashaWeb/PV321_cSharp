using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "bytes.dat";
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
            {
                byte value = 65;
                byte[] arr = { 10, 2, 5, 8, 7, 4, 5 };

                fs.WriteByte(value);
                fs.Write(arr, 0, arr.Length);

                Console.WriteLine($"Position cursor {fs.Position}");
                //fs.Position = 0;
                fs.Seek(0, SeekOrigin.Begin); //fs.Position = 0;
                Console.WriteLine($"Position cursor Begin {fs.Position}");
                fs.Seek(0, SeekOrigin.End);
                Console.WriteLine($"Position cursor End {fs.Position}");
                fs.Seek(-2, SeekOrigin.End);
                Console.WriteLine($"Position cursor End {fs.Position}");
                fs.Position = 0;

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                Console.WriteLine($"Print {String.Join<byte>("\t ", buffer)}");
            }



            //fs.Close();
        }
    }
}
