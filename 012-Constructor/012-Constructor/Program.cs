using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var P0 = new Pessoa();

            Console.WriteLine($"{P0.Codigo} -> {P0.Nome}");

            var P1 = new Pessoa(2, "Leeeeeooon");

            Console.WriteLine(P1.Codigo);
            Console.WriteLine(P1.Nome);

            //P1.Codigo = 352;
            P1.Nome = "Leonildo";

            Console.WriteLine($"{P1.Codigo} -> {P1.Nome}");

            P1.aumentaCodigo();

            Console.WriteLine($"{P1.Codigo} -> {P1.Nome}");

            var P3 = new Pessoa { Codigo = 33, Nome = "jose" };
            // nao funciona pois coloquei codigo como private e ele
            // precisa ser informado em um construtor e não em um
            // inicializador de objeto.


            Console.ReadKey();

        }
    }

    class Pessoa
    {
        //default constructor (gerado pelo compilador)
        //Cria valores para todo campo como default
        // numerico = 0, boolean = falso, reference_type = null, String=''
        //Usando ctor e tab ele cria um construtor com o mesmo nome da classe
        //: no construtor representa uma chamada
        public Pessoa():this(-1,"não informado")
        {

        }

        //sobrecarga
        public Pessoa(int codigo, String nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public int Codigo { get; private set; }
        public String Nome { get; set; }

        public void aumentaCodigo ()
        {
            Codigo += 10;
        } 

    }
}
