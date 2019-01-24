using System;

namespace _007_Property
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pessoa P;
            //P = new Pessoa;

            var p = new Pessoa(); // significa a mesma coisa que Pessoa p = new Pessoa();

            p.Codigo = 1;
            p.Nome = "adao";

            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Nome);

            var produto = new Produto();

            produto.Codigo = 10;
            produto.Nome = "Café";
            produto.Preco = 12.6;

            Console.WriteLine($"{produto.Codigo} - O preco do {produto.Nome} é {produto.Preco}");


            Console.ReadKey();
           
        }
    }

    class Pessoa
    {
        int codigo;
        String nome;

        //property --> no java é o setter e o getter

        public int Codigo 
        {// usa com letra maiuscula
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Informe um cõdigo positivo");
                }
                codigo = value;
            }
            get { return codigo; }

        }

        public String Nome
        {
            set { nome = value; }
            get { return nome; }

        }

    }

    class Produto
    {

        
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public double Preco { get; set; }


    }
}
