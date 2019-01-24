using System;

namespace _018_GenericStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posicao c;
            //Posicao<int> c;//para trabalhar com item generico
            Posicao<int, int> c;//para trabalhar com item generico
            c.x = 10;
            c.y = 20;

            Console.WriteLine($"({c.x},{c.y})");

            //Posicao<String> x;
            Posicao<String,int> x;//trabalhar com mais de um item

            x.x = "A";
            x.y = 3;

            Console.WriteLine($"({x.x}{x.y})");

            Console.ReadKey();
        }
    }

    //struct Posicao
    //{
    //    public int x;
    //    public int y;
    //}

    //transformando em generico
    //struct Posicao<T>
    struct Posicao<T1,T2> // quando tenho mais de um tipo
    {
        public T1 x;
        public T2 y;
    }
}
