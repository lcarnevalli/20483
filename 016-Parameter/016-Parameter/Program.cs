using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameter array.
            // como passar uma array como parametro do metodo.

            int[] Numeros = { 1, 3, 5, 2, 4, 6 };
            String[] Nomes = {"Leo","Mari","Rafael","João Pedro" };

            Imprimir(Numeros);
            Imprimir(Nomes);
            Console.WriteLine(Somar(Numeros));

            //Console.WriteLine(Somar(new int[] {1,2,4,7}));
            // essa uma forma sem utilizar o params.

            Console.WriteLine(Somar(1,2,4,5,6,34,5,6));

            Console.ReadKey();
        }

        private static int Somar(params int[] numeros)
        {// params tem que ser o último parametro que se coloca
            int resultado = 0;

            foreach (var item in numeros)
            {
                resultado += item;
            }
            return resultado;
            //throw new NotImplementedException();
        }

        private static void Imprimir(string[] nomes)
        {
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            //throw new NotImplementedException();
        }

        private static void Imprimir(int[] numeros)
        {
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            // throw new NotImplementedException();
        }
    }
}
