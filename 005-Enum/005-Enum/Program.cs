using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p;

            //inicialização do objeto
            p = new Pessoa();

            p.codigo = 1;
            p.nome = "joao";
            p.sexo = Sexo.Masculino;

            Console.WriteLine(p);

            Console.WriteLine(p.nome);
            Console.WriteLine(p.codigo);
            Console.WriteLine(p.sexo);

            Console.ReadKey();
        }
    }
    enum Sexo //normalmente é heradao do inteiro
    {
        Masculino, //0 = quando não informado inicia por ele
        Feminino //1 - se não foi definido o segundo ele pega a continuidade do primeiro

        /*
        Masculino = 37, //0
        Feminino = 46 //1
         */
    }
    class Pessoa
    {
        internal int codigo;
        internal String nome;
        internal Sexo sexo;

        public override string ToString()
        {
            return (codigo + "\t" + nome + "\t" + sexo );
        }

    }
}
