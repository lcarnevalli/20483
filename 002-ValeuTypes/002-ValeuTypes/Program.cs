using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ValeuTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region nomenclatura
            /*
             Notacao Hunbara:
             intIdade, strNome, lblMensagem,
             cmdOK, txtNome
             NÃO É MAIS UTITILIZADO A NOTAÇÃO HUNGARA   

            Notação Camelcasing - tipos, memros publicos (TEM ACESSO EXTERNO)
             NomeDoSujeito, PessoaFisica 

            Notação PacalCasign - memros não publicos
             idade, sexo, nomeProduto, preco

            Notação Snake_Caisng - constante
              COR_DO_SANGUE

             */
            #endregion

            Console.WriteLine("{0}: {1:n0} até {2:n0}.", "int", int.MinValue,int.MaxValue);

            Console.WriteLine("{0}: {1:n0} até {2:n0}.", "double", double.MinValue, double.MaxValue);

            Console.WriteLine("{0}: {1:n0} até {2:n0}.", "decimal", decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("{0}: {1:n0} até {2:n0}.", "char", (int)char.MinValue, (int)char.MaxValue);

            Console.WriteLine("{0}: {1} até {2}.", "dateTime", DateTime.MinValue, DateTime.MaxValue);

            Console.ReadKey();

            //ctrl+mouse whell - text size

            //CTRL+U - UpperCase
            //ctrl+shift+u - LowerCase

        }
    }
}
