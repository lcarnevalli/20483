using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p; // declara a variável
            p = new Pessoa(); // instancia a variavel

            p.codigo = 1; // acessa membro
            p.nome = "Adao";

            Console.WriteLine( p.codigo);
            Console.WriteLine(p.nome);

            String s = "agnaldo"; // string é um reference type que inicializa como uma value type

            String outra;// O reference type inicializando como string
            outra = new string(); // você tem varios construtores mas não precisa se preocupar.




            Console.ReadKey();

        }
    }

    class Pessoa
    {
        internal int codigo; // não deve ser utilizado para acesso externo.

        internal String nome;

    }
}
