using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_indexers
{
    class Matrix
    {
        int[,] matrix;
        public Matrix(int row = 2, int col =2)
        {
            matrix = new int[row, col];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j],7}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public int this[int r, int c]
        {
            get { return matrix[r, c]; }
            set { matrix[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(5,10);
            Console.WriteLine(m);
            m[2, 3] = 333;
            Console.WriteLine(m);
        }
    }
}
