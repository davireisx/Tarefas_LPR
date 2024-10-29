using Aula_11;
using System;

namespace Aula_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.Write("Insira a altura do retângulo: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.Write("Insira a largura do retângulo: ");
            retangulo.largura = double.Parse(Console.ReadLine());
            retangulo.calcArea();
            retangulo.calcPerimetro();

            Console.WriteLine($"A área do triângulo é {retangulo.area}");
            Console.WriteLine($"O perímetro do triângulo é {retangulo.perimetro}");
        }
    }
}