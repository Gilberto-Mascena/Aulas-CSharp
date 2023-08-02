using System;
using System.Globalization;

namespace PrimeiroProjeto 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            string nome = "Maria";
            int idade = 32;
            double saldo = 12.34569;

            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            /* .ToString("F4" formata a quantidade de casas decimais, 
             * CultureInfo.InvariantCulture deixa o ponto como padrão de separador de decimal.)
             */

            Console.WriteLine("{0} tem {1} anos de idade e saldo de {2:F2} reais", nome, idade, saldo);
            /* A impresão acima é definida como placeholder*/

            Console.WriteLine($"{nome} tem {idade} anos de idade e saldo de {saldo:F2} reais");
            /* A impresão acima é definida como interpolação*/

            Console.WriteLine(nome + " tem " + idade + " anos de idade e saldo de " +  saldo.ToString("F2") + " reais");
            /* A impresão acima é definida com concatenação */
        }
    }
}
