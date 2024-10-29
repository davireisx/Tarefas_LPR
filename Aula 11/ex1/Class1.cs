using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Retangulo
    {
        public double altura, largura, area, perimetro;

        public double calcArea()
        {
            return area = altura * largura;
        }

        public double calcPerimetro()
        {
            return perimetro = altura * 2 + largura * 2;
        }
    }
}