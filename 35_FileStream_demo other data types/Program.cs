using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_FileStream_demo_other_data_types
{
    internal class Program
    {
        static void WriteInt(int value, string path)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = BitConverter.GetBytes(value);
                fs.Write(buffer, 0, buffer.Length);
            }
        }
        static int ReadInt(string path)
        {
            int value = 0;

            using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[sizeof(int)];//BitConverter.GetBytes(value);
                fs.Read(buffer, 0, buffer.Length);
                value = BitConverter.ToInt32(buffer, 0);
            }

            return value;
        }
        static void WriteStr(string value, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = Encoding.Unicode.GetBytes(value);
                fs.Write(buffer,0, buffer.Length);
            }
        }
        static string ReadStr(string path)
        {
            string value = String.Empty;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer,0, buffer.Length);
                value = Encoding.Unicode.GetString(buffer);
            }

            return value;
        }
        static void WriteIntFs(int value, FileStream fs)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            fs.Write(buffer, 0, buffer.Length);
        }
        static int ReadIntFs(FileStream fs)
        {
            int value = 0;

            byte[] buffer = new byte[sizeof(int)];//BitConverter.GetBytes(value);
            fs.Read(buffer, 0, buffer.Length);
            value = BitConverter.ToInt32(buffer, 0);

            return value;
        }
        static void Main(string[] args)
        {
            //string fname = "number.dat";
            //WriteInt(-1254, fname);
            //Console.WriteLine($"Result int :: {ReadInt(fname)}");

            /*string fname = "string.dat";
            //WriteStr("Hello_Привіт", fname);
            Console.OutputEncoding= Encoding.Unicode;
            Console.WriteLine($"Result string :: {ReadStr(fname)}");*/
            string fname = "number.dat";
            /*using(FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write))
            {
                int[] arr = { -10, 20, 30, -40, 55, 12 };
                foreach (var item in arr)
                {
                    WriteIntFs(item, fs);
                }
            }*/

            using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                int[] arr = new int[(int)(fs.Length / sizeof(int))];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ReadIntFs(fs);
                    Console.Write($"{arr[i],7}");
                }
                Console.WriteLine();
            }
        }
    }
}
