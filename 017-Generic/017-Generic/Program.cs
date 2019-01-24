using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3 };
            double[] d = { 1, 2.901, 54.5 };
            String[] s = { "Leonildo", "Mari" };

            Imprimir(d);
            Imprimir(x);
            Imprimir(s);

            Console.ReadKey();

        }

        //private static void Imprimir<Tipo>(Tipo[] d)
        private static void Imprimir<T>(T[] d)
            // este método respondo para qualquer tipo.
        {
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
           // throw new NotImplementedException();
        }
    }
}
