using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_triangulo_3_valores___logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do primeiro lado:");
            double lado1;
            while (!double.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
            {
                Console.WriteLine("Entrada inválida! Digite um número valido para o primeiro lado:");
            }

            Console.WriteLine("Digite o valor do segundo lado:");
            double lado2;
            while (!double.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
            {
                Console.WriteLine("Entrada inválida! Digite um número valido para o segundo lado:");
            }

            Console.WriteLine("Digite o valor do terceiro lado:");
            double lado3;
            while (!double.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
            {
                Console.WriteLine("Entrada inválida! Digite um número valido para o terceiro lado:");
            }

            if (FormaTriangulo(lado1, lado2, lado3))
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo.");
            }
        }
        //???
        private static bool FormaTriangulo(double lado1, double lado2, double lado3) => lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
    }
}
