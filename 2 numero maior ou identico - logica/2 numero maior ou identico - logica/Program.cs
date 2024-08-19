using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_numero_maior_ou_identico___logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;


            Console.Write("Insira o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O maior valor é: " + valor1);
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }
            else
            {
                Console.WriteLine("Os números são idênticos.");
            }

        }
    }
}
