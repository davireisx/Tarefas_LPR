using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Aula12
{
    internal class Biblioteca
    {
        string nome { get; set; }

        List<Livro> livros = new List<Livro>();

        public Biblioteca(string nome)
        {
            this.nome = nome;
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros()
        {
            Console.WriteLine($"{nome}");
            foreach (Livro livro in livros)
            {
                Console.WriteLine($"\nLivro: {livro.titulo}");
                Console.WriteLine($"Autor: {livro.autor}");
                Console.WriteLine($"Ano de publicação: {livro.anoPublicacao}");
            }
        }
    }
}
