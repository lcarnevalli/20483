using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Dividir(10, 3);
            Dividir(10);

            Dividir(y: 45, x: 1293); // utilizando parametro nomeado

            Console.ReadKey();
        }
        // como está dentro da mesma classe e será chamado por uma função main statica, este método tem que ser estático
        static void Dividir(double x, double y = 2) { Console.WriteLine(x/y); }
        // todos os parametros opcionais tem que vir no final.

    }
}
