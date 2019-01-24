using System;

namespace _010_Overload // Sobrecarga - mesmo métido escrito de forma diferente.
{
    class Program
    {
        static void Main(string[] args)
        {
            Dividir(1 , 7);

            Dividir(1, 7, 4);
            Dividir(1F, 7); // 1F = Fload e não é convertido automaticamente. 
            Dividir(1.0, 7); // 1.0 = double
            Dividir(1M, 7); // 1M = Decimal


            Console.ReadKey();
        }

        static void Dividir(int x, int y) { Console.WriteLine(x/y); }
        static void Dividir(int x, int y, int z) { Console.WriteLine(x / y/z); }
        static void Dividir(double x, int y) { Console.WriteLine(x / y); }
        static void Dividir(float x, int y) { Console.WriteLine(x / y); }
        static void Dividir(decimal x, int y) { Console.WriteLine(x / y); }
        //Regras de sobrecarga
        //Nome do metodo tem que ser igual
        //Assinatura do metodo - Nome + parameter types

    }
}
