using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Funcionario
    {
        public string nome;
        public double salario, imposto;

        public void mostrarValores()
        {
            Console.WriteLine($"O nome do funcionário é {nome} e seu salário líquido é de R${salario}");
        }

        public double aumentoSalario()
        {
            if (salario <= 2000)
            {
                imposto = (0.10 * salario);
                return salario += imposto;
            }

            else if (salario <= 3000)
            {
                imposto = 0.15 * salario;
                return salario += imposto;
            }

            else
            {
                imposto = (0.20 * salario);
                return salario += imposto;
            }
        }
    }
}