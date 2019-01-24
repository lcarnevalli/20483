using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Output_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int retX, retY;

            SomaProduto(10, 20, out retX, out retY);

            Console.WriteLine($" A soma ->{retX}");
            Console.WriteLine($" O Produto ->{retY}");

            Duplicar(ref retY);

            Console.WriteLine($"depois de chamar o Dublicar: {retY}");

            Console.ReadKey();
        }

        static void SomaProduto (int x, int y, out int s, out int p)
        {
            s = x + y;
            p = x * y;
        }

        static void Duplicar (ref int x)
        {
            x *= 2;
            Console.WriteLine($"dentro do Duplicar: {x}");

        }
    }
}
