using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Oficina
    {
        private List<Reserva> l_reservas = new();

        public List<Reserva> L_reservas { get => l_reservas; }

        internal delegate void delegadoRes();
        internal event delegadoRes eventoReserva;

        internal void Informar_Nueva_Reserva(Reserva res)
        {
            try
            {
                if (eventoReserva != null)
                {
                    eventoReserva();

                    Console.WriteLine($"Nueva Reserva, Habitacion {res.Habreserva.Nom}");
                    l_reservas.Add(res);
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void Eliminar_Reserva(Reserva res)
        {
            try
            {
                if (eventoReserva != null)
                {
                    eventoReserva();

                    Console.WriteLine($"Cancelando Reserva, Habitacion {res.Habreserva.Nom}");
                    l_reservas.Remove(res); 
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
