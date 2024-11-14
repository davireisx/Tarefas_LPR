using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public float nota1, nota2, trabalho;
        private const float pesoProva = 2.5f; 
        private const int pesoTrabalho = 2;   
        private const double mediaMinima = 6;  

       
        public double calcularMedia()
        {
            double mediaFinal = ((nota1 * pesoProva) + (nota2 * pesoProva) + (trabalho * pesoTrabalho)) / (2 * pesoProva + pesoTrabalho);
            return mediaFinal;
        }
        public double Final()
        {
            double mediaFinal = calcularMedia();
            if (mediaFinal >= mediaMinima)
            {
                return 0; 
            }
            else
            {
                double notaNecessaria = (mediaMinima * (2 * pesoProva + pesoTrabalho) - (nota1 * pesoProva + nota2 * pesoProva + trabalho * pesoTrabalho)) / pesoProva;
                return Math.Max(0, notaNecessaria); 
            }
        }
    }
}