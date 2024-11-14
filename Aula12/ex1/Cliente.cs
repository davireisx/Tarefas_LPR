using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Aula12
{
    internal class Cliente
    {
        public string nome { get; set; }
        List<Reserva> reservas = new List<Reserva>();

        public Cliente(string Nome)
        {
            nome = Nome;
        }

        //Metodo para adicionar uma reserva 
        public void addReserva(Reserva reservasnovas)
        {
            reservas.Add(reservasnovas);
        }

        public void mostrarReservas()
        {
            Console.WriteLine($"\nCliente: {nome}");
            foreach (Reserva reservou in reservas)
            {
                Console.WriteLine($"Reserva: {reservou.iD}");
                Console.WriteLine($"Dia: {reservou.data}");
            }
        }

    }
}
