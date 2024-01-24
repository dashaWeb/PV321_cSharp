using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_BinaryReader_Writer
{
    internal class Program
    {
        static void BinaryWriterDemo()
        {
            string fname = "my.dat";
            using (BinaryWriter br = new BinaryWriter(new FileStream(fname, FileMode.Create, FileAccess.Write)))
            {
                string text = "Test line _ тестовий рядок";
                int value = 4521;
                double valueD = 25.36;
                int[] arr = { 45, 15, 12, 36 };


                br.Write(text);
                br.Write(value);
                br.Write(valueD);

                br.Write(arr.Length);
                foreach (var item in arr)
                {
                    br.Write(item);
                }
            }
        }
        static void BinaryReaderDemo()
        {
            string fname = "my.dat";
            using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open, FileAccess.Read)))
            {

                string res = br.ReadString();
                Console.WriteLine($"Read string :: {res}");
                Console.WriteLine($"Read Int    :: {br.ReadInt32()}");
                Console.WriteLine($"Read Double :: {br.ReadDouble()}");

                var len = br.ReadInt32();
                int[] arr = new int[len];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = br.ReadInt32();
                    Console.Write($"{arr[i],7}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //BinaryWriterDemo();
            Console.OutputEncoding= Encoding.UTF8;
            BinaryReaderDemo();
        }
    }
}
