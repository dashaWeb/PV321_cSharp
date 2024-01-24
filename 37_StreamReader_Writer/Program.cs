using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_StreamReader_Writer
{
    internal class Program
    {
        static void StreamWriterDemo()
        {
            string fname = "data.txt";
            using(StreamWriter sw = new StreamWriter(fname)) {

                string text = "Test line _ тестовий рядок";
                int value = 4521;
                double valueD = 25.36;
                int[] arr = { 45, 15, 12, 36 };

                sw.WriteLine(text);
                sw.WriteLine(value);
                sw.WriteLine(valueD);
                sw.WriteLine($"Length array :: {arr.Length}");
                foreach (var item in arr)
                {
                    sw.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            //StreamWriterDemo();
            Console.OutputEncoding= Encoding.UTF8;
            string path = "data.txt";
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"\n\n{new string('*',40)} Way #1 (ReadAllText) {new string('*', 40)} ");
            Console.WriteLine(File.ReadAllText(path));


            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine($"\n\n{new string('*', 40)} Way #2 (ReadAllLines) {new string('*', 40)} ");
            var lines = File.ReadAllLines(path);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\n{new string('*', 40)} Way #3 (ReadToEnd) {new string('*', 40)} ");

            using(StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n{new string('*', 40)} Way #3 (Line by line) {new string('*', 40)} ");

            using (StreamReader sr = new StreamReader(path))
            {
                string line = String.Empty;
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n\n{new string('*', 40)} Way #3 (Char by char) {new string('*', 40)} ");

            using (StreamReader sr = new StreamReader(path))
            {
                int symbol;
                while ((symbol = sr.Read()) != -1)
                {
                    Console.Write($"{(char)symbol}");
                }
                Console.WriteLine();
            }

        }
    }
}
