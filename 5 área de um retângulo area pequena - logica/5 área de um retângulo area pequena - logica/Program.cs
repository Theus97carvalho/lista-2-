using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_área_de_um_retângulo_area_pequena___logica
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

            area = baseRetangulo * alturaRetangulo;

            Console.WriteLine($"A área do retângulo é: {area}");

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}