using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula12
{
    internal class Reserva
    {
        public int iD { get; }
        static int cont = 1;
        Cliente cliente;
        public int data { get; set; }

        public Reserva(Cliente cliente, int data)
        {
            this.data = data;
            this.cliente = cliente;
            this.iD = cont;
            cont++;
        }
    }
}
