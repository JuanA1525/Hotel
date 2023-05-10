using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Reserva
    {
        private Habitacion habreserva;
        private List<Producto> resProductos;
        private List<Comida> resComidas;
        private List<Servicio> resServicios;

        public Reserva(Habitacion hab)
        {
            habreserva = hab;
        }

        public Habitacion Habreserva { get => habreserva; }
    }
}
