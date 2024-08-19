using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_escola_semestre_aprovado_reprovado___logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P1;
            double P2;
            double media;

            Console.WriteLine("Digite o valor da P1");
            P1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da P2");
            P2 = Convert.ToDouble(Console.ReadLine());

            media = (P1 + 2 * P2) / 3;
            Console.WriteLine($"Média do aluno: {media:F2}");

            if (media >= 5.0)
            {
                Console.WriteLine("Situação: Aprovado");
            }
            else
            {
                Console.WriteLine("Situação: Reprovado");


            }
        }
    }
}