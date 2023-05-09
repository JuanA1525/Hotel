using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Usuario
    {
        private Reserva? reservaUsu;
        private string nombre;
        private byte edad;
        private static Oficina office = new Oficina();

        internal Reserva? ReservaUsu { get => reservaUsu; }
        public Oficina Office { get => office; }

        public Usuario (string nom, byte age)
        {
            nombre = nom;
            edad = age;
            reservaUsu = null;
        }

        public void Event_Handler_Reservas()
        {
            Console.WriteLine("Procesando Reserva");
        }

        public void Crear_Reserva(Habitacion hab)
        {
            try
            {
                if (!(reservaUsu != null))
                {
                    reservaUsu = new Reserva(hab);
                    reservaUsu.Habreserva.ReservaActual = reservaUsu;
                    reservaUsu.Habreserva.Ocupada = true;

                    Office.eventoReserva += Event_Handler_Reservas;
                    Office.Informar_Nueva_Reserva(reservaUsu);
                    Office.eventoReserva -= Event_Handler_Reservas;
                }
                else
                    Console.WriteLine("Usted ya tiene Reserva");
            }
            catch (Exception error)
            {
                throw new Exception("Error en crear reserva " + error);
            }
        }
        public void Eliminar_Reserva ()
        {
            try
            {
                if (reservaUsu != null)
                {
                    Office.eventoReserva += Event_Handler_Reservas;
                    Office.Eliminar_Reserva(reservaUsu);

                    reservaUsu.Habreserva.ReservaActual = null;
                    reservaUsu.Habreserva.Ocupada = false;
                    reservaUsu = null;

                    Office.eventoReserva -= Event_Handler_Reservas;
                }
                else
                    Console.WriteLine("Usted ya tiene Reserva");
            }
            catch (Exception error)
            {
                throw new Exception("Error en crear reserva " + error);
            }
        }

    }
}
