using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_IMC___logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            Console.WriteLine("Digite o peso da pessoa em kg:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da pessoa em metros:");
            altura = double.Parse(Console.ReadLine());

            imc = CalcularIMC(peso, altura);

            Console.WriteLine($"O IMC da pessoa é: {imc}");

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}
