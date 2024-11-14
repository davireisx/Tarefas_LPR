using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("Percy Jackson", "Rick Riordan", 2012);
            Livro livro2 = new Livro("Renegados", "Marissa Meyer", 2015);
            Livro livro3 = new Livro("Warcross", "Marie Lu", 2017);

            Biblioteca biblioteca = new Biblioteca("Biblioteca Nacional do Brasil");
            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);
            biblioteca.AdicionarLivro(livro3);

            biblioteca.ListarLivros();

            Console.ReadLine();
        }
    }
}
