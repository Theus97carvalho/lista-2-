using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetanguloLogica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo;
            double alturaRetangulo;
            double area;

            Console.WriteLine("Digite o valor da base do retângulo:");
            baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do retângulo:");
            alturaRetangulo = double.Parse(Console.ReadLine());

            area = CalcularAreaRetangulo(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"A área do retângulo é: {area}");

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }

            double CalcularAreaRetangulo(double baseRetangulo, double alturaRetangulo) => baseRetangulo * alturaRetangulo;
            //não consegui corrigir o erro a cima 

        }
    }
}
