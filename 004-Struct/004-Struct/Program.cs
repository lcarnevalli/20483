using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao f; //inicia uma variavel do tipo fração
            f.n = 1;
            f.d = 2;
            Console.WriteLine($"{f.n}/{f.d}");
            Console.WriteLine(f.ToString());
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }

    struct Fracao
    {
        //tudo que está aqui (como membro) é private
        //você tem que colocar como public 
        //No caso da strutura ele é definido como internal e aí pode ser localizado.
        //se você deixar o tipo publico ele não deixa o membro como publico.

        internal int n;//numerador - para ser acessado precisa ser public ou internal
        public int d; //denominador - para ser acessado precisa ser public ou internal
        public override string ToString()
        {

            //return base.ToString(); - chama o toString da classe object (super classe)

            return $"{n}/{d}";
        }
    }
}
