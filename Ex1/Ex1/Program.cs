using System;
using System.Globalization;

namespace Ex1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quantidadeQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProd = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");

            string[] vet = Console.ReadLine().Split(" ");
            string sobreNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuarto);
            Console.WriteLine(precoProd.ToString("F2"));
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
