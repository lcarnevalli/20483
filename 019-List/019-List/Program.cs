using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections
            //System.Collections.Generic
            //System.Collections.Specialized
            var a = new ArrayList();
            a.Add("Leonildo");
            a.Add(123);
            a.Add(123.22);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // versão de list tipada

            var l = new List<int>();

            l.Add(1);
            l.Add(11);
            l.Add(122);
            l.AddRange(new int[] { 2,4,7,5,3,2,6,99,1 });

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // ordenar uma lista
            l.Sort();
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            l.Reverse();
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            // ordenar uma array

            int[] x = { 3, 5, 23, 4, 5, 2, 5 };
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Array.Sort(x);

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //definindo uma lista.
            var pessoas = new List<Pessoa>
            {
                new Pessoa {Codigo = 1, Nome = "Adao"},
                new Pessoa {Codigo = 2, Nome = "Eva"},
                new Pessoa {Codigo = 3, Nome = "Cain"},
                new Pessoa {Codigo = 4, Nome = "Abel"}

            };

            foreach (var item in pessoas)
            {
                Console.WriteLine($"{item.Codigo} -> {item.Nome}");
            }

            Console.WriteLine(" Oerdenando");

            pessoas.Sort();

            foreach (var item in pessoas)
            {
                Console.WriteLine($"{item.Codigo} -> {item.Nome}");
            }

            Console.ReadKey();

        }
    }

    class Pessoa : IComparable<Pessoa>
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }

        public int CompareTo(Pessoa other)
        {
            return this.Nome.CompareTo(other.Nome);

            //throw new NotImplementedException();
        }
    }
}
