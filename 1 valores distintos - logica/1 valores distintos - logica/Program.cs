using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_valores_distintos___logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Insira o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O maior valor é: " + valor1);
            }
            else
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }
        }
    }
}