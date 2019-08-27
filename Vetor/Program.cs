using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] Alug = new Aluguel[10];

            Console.Write("Quantos quartos vc vai alugar: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Email: ");
                string Email = Console.ReadLine();
                Console.Write("Quarto: ");
                int Quarto = int.Parse(Console.ReadLine());
                Alug[Quarto] = new Aluguel(Nome, Email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (Alug[i] != null)
                {
                    Console.WriteLine(i + ": " + Alug[i]);
                }
            }
            Console.ReadLine();
        }
    }
}


