using Aula_11;
using System;

namespace Aula_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Insira o nome do funcionário: ");
            funcionario.nome = Console.ReadLine();

            Console.Write("Insira o salário do funcionário: ");
            funcionario.salario = double.Parse(Console.ReadLine());

            funcionario.mostrarValores();
            funcionario.aumentoSalario();

            Console.WriteLine($"Agora o salário com imposto do funcionário é R${funcionario.salario} ");
        }
    }
}