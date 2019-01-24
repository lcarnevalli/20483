using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            var n1 = new int[] { 1, 2, 3 };
            var n2 = new int[] { 10, 20 };
            var n3 = new int[] { 100, 200,300,400};
            var n = new int[][] { n1, n2, n3 };

            foreach (var item in n)
            {
                Console.WriteLine(item);
            }

            foreach (var itemi in n)
            {
                foreach (var itemj in itemi)
                {
                    Console.WriteLine(itemj);
                }

            }

            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n[i].Length; j++)
                {
                    Console.WriteLine(n[i][j]);
                }
            }

            Console.ReadKey();

        }
    }
}
