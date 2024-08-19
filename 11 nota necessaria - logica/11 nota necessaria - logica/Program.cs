using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_nota_necessaria___logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1;
            double valorP2;

            Console.WriteLine("Digite a nota da primeira avaliação (P1):");
            P1 = double.Parse(Console.ReadLine());

            valorP2 = (5 * 3 - P1) / 2;

            Console.WriteLine($"Para ser aprovado, você precisa tirar no mínimo {valorP2:F2} na segunda avaliação (P2).");
        }
    }
}
