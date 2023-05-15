using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Reserva
    {
        private Habitacion habreserva;
        private Usuario usuarioReserva;
        private byte nroNoches;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private TimeSpan tiempoEstadia;

        private List<Producto> resProductos;
        private List<Comida> resComidas;
        private List<Servicio> resServicios;
        private int nro_ServiciosCuarto;

        public Reserva(Habitacion hab, Usuario usu, string fEntrada, string fSalida)
        {
            Habreserva = hab;
            UsuarioReserva = usu;
            
            resProductos = new();
            resComidas = new(); 
            resServicios = new(); 
            nro_ServiciosCuarto = new();
            FechaEntrada = DateTime.ParseExact(fEntrada, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            FechaSalida = DateTime.ParseExact(fSalida, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            tiempoEstadia = FechaSalida - FechaEntrada;
            nroNoches = (byte)tiempoEstadia.Days;
        }

        public Habitacion Habreserva { get => habreserva; set => habreserva = value; }
        public List<Producto> ResProductos { get => resProductos; set => resProductos = value; }
        public List<Comida> ResComidas { get => resComidas; set => resComidas = value; }
        public List<Servicio> ResServicios { get => resServicios; set => resServicios = value; }
        public Usuario UsuarioReserva { get => usuarioReserva; set => usuarioReserva = value; }
        public int Nro_ServiciosCuarto { get => nro_ServiciosCuarto; set => nro_ServiciosCuarto = value; }
        public byte NroNoches { get => nroNoches; set => nroNoches = value; }

        public DateTime FechaEntrada 
        { 
            
            get => fechaEntrada;
            
            set 
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentException("La fecha de entrada no puede ser anterior a Hoy");
                }
            } 
        }

        public DateTime FechaSalida 
        { 
            get => fechaSalida;

            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentException("La fecha de salida no puede ser anterior a Hoy");
                }

                if (value < FechaEntrada)
                {
                    throw new ArgumentException("La fecha de salida no puede ser anterior a la fecha de entrada");
                }
            }
        }
    }
}
