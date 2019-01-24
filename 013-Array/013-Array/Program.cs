using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numeros = new int[5]; //mesmo comando abaixo
            var numeros = new int[5];
            numeros[0] = 12;
            numeros[1] = 122;
            numeros[2] = 1222;
            numeros[3] = 12222;
            numeros[4] = 122222;

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            //var nomes = { "Leo", "Mari", "Joao", "Rafael" };
            // não funciona pois o var não sabe o tipo.
            string[] nomes2 = { "Leo", "Mari", "Joao", "Rafael" };
            var nomes = new String[] { "Leo", "Mari", "Joao", "Rafael" };
            //
            foreach (var item in nomes)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(Array.IndexOf(numeros,1222));
            // indexoff ele pega o primeiro elemento que achar

            Console.WriteLine(Array.LastIndexOf(nomes,"Mari"));
            // lastindexoff ele pega o primeiro elemento a partir do último.

            Console.ReadKey();

        }
    }
}
