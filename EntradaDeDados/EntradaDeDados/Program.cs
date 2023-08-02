using System;

namespace EntradaDeDados 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /* Entrada ou leitura de dados em CSharp é com Console.ReadLine() */
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            /*
             * Recebendo dados recortando com a função Split e armazenando 
             * num vetor, depois atribuindo os valores recortados em variavéis. 
             */
            string s = Console.ReadLine();

            string[] vet = s.Split(" ");

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

        }
    }
}
