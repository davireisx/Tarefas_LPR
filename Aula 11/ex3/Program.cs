using Aula_11;
using System;

namespace Aula_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Insira o nome do aluno: ");
            aluno.nome = Console.ReadLine();

            Console.Write("Insira a matrícula do aluno: ");
            aluno.matricula = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Insira a primeira nota da prova: ");
            aluno.nota1 = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Insira a segunda nota da prova: ");
            aluno.nota2 = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Insira a nota do trabalho: ");
            aluno.trabalho = float.Parse(Console.ReadLine() ?? "0");

            double mediaFinal = aluno.calcularMedia();
            Console.WriteLine($"A média final de {aluno.nome} é {mediaFinal:F2}")

            double notaNecessariaFinal = aluno.Final();
            if (notaNecessariaFinal > 0)
            {
                Console.WriteLine($"{aluno.nome} precisa de {notaNecessariaFinal:F2} na prova final para atingir a média 6.");
            }
            else
            {
                Console.WriteLine($"{aluno.nome} não precisa de prova final.");
            }
        }
    }
}