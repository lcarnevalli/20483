using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[3,2];

            numeros[0, 0] = 1;
            numeros[0, 1] = 11;
            numeros[1, 0] = 111;
            numeros[1, 1] = 1111;
            numeros[2, 0] = 11111;
            numeros[2, 1] = 111111;
           foreach (var item in numeros)
	        {
                 Console.WriteLine( item);
	        }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine(numeros[i,j]);

                }
            }


            Console.ReadKey();

        }


        
    }
}
