using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_LIteralVariavelConstante
{
    class Program
    {
        static String nome = "joao";//tem que colocar static para utilizar em uma função static;
        int idade = 52;

        static void Main(string[] args)

        {
            Console.WriteLine(nome);

            int idd = new Program().idade;//maneira de usar um valor nao estático dentro de uma função estática
            Console.WriteLine(idd);

            //code sneped
            //ctrl+k, ctrl+x --> insert snippet
            //você pode fazer o seu.

            Console.WriteLine(10);//int
            Console.WriteLine(1.12);//double
            Console.WriteLine('a');//char
            Console.WriteLine("teste");//String
            Console.WriteLine(true);//boolean

            //declarar uma variavel (valeu type);
            //tipo nome;
            //tipo nome1, nome2

            int x;
            int y, z;

            //atribuir valor a uma variável

            x = 10;
            y = z = 100;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //constante
            //const tipo NOME=conteudo;

            const String COR_DO_SANGUE = "Vermelho";

            Console.WriteLine($"O leonildo tem a cor do sangue igual a {COR_DO_SANGUE}");
            // STRING INTERPOLADA $"O le

            Console.WriteLine($"O leonildo tem a cor do sangue igual a {(COR_DO_SANGUE + "OI")}");

            Console.ReadKey();

            //TELERIK > JUST DECOMPILE

            //ctrl+space chame o intelisense

            Console.WriteLine(10L);//long
            Console.WriteLine(10.34f);//fload
            Console.WriteLine(12.32m);//decimal
        }

    }
}
