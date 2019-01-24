using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa()
            {//inicializador de obrjetos - object initializer
                Codigo = 1, 
                Nome = "Adão",
                Salario = 22.5
            };
            

            Console.WriteLine(p.Imprimir());

            Console.WriteLine(  );
            
            /*var c = new Calculadora();

            Console.WriteLine(c.Somar(1,2));
            Console.WriteLine(c.Subtrair(1, 2));
            Console.WriteLine(c.Multiplicar(1, 2));
            Console.WriteLine(c.Dividir(1, 2));
            */

            // Posso chamar o metodo de uma classe de forma diferente
            // Eu crio os metodos estaticos dentro de uma classe então posso chama-la diretamente Calculadora.Somar em vez de instanciar uma variável.

            Console.WriteLine(Calculadora.Somar(1, 2));
            Console.WriteLine(Calculadora.Subtrair(1, 2));
            Console.WriteLine(Calculadora.Multiplicar(1, 2));
            Console.WriteLine(Calculadora.Dividir(1, 2));

            Console.ReadKey();
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public double Salario { get; set;}


        public String Imprimir()
        {

            return $"{Codigo} -> {Nome} com o salario de {Salario}";
        }
    }

    //class Calculadora // metodo de instancia precisa de uma variável para inicializar. não dá para chamar direto
    //{
    //        public double Somar (double x, double y)
    //    {
    //        return (x + y);
    //    }
    //    public double Subtrair (double x, double y)
    //    {
    //        return (x - y);
    //    }
    //    public double Multiplicar (double x, double y)
    //    {
    //        return (x * y);
    //    }
    //    public double Dividir (double x, double y)
    //    {
    //        return (x / y);
    //    }
    //}

   class Calculadora
    {
        // static indica que posso acessar diretamente o metodo.
       public static double Somar (double x, double y) {return (x + y);}
       public static double Subtrair (double x, double y) { return (x - y); }
       public static double Multiplicar (double x, double y) { return (x*y); }
       public static double Dividir (double x, double y) { return (x / y); }
    }

}

