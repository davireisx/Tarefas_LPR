using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            Cliente cliente = new Cliente(Console.ReadLine());

            Console.WriteLine("Digite o dia da primeira reserva: ");
            Reserva r1 = new Reserva(cliente, int.Parse(Console.ReadLine()));
            cliente.addReserva(r1);

            Console.WriteLine("Digite o dia da segunda reserva: ");
            Reserva r2 = new Reserva(cliente, int.Parse(Console.ReadLine()));
            cliente.addReserva(r2);

            cliente.mostrarReservas();

            Console.ReadLine();

        }
    }
}
