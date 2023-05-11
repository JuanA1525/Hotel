using b_Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Habitacion_Suite : Habitacion , I_MiniBar
    {
        public Habitacion_Suite() : base()
        {
            Ocupada = false;
            ReservaActual = null;
            PrecioNoche = precioSuite;

            Llenar_MiniBar();
        }

        public void Llenar_MiniBar()
        {
            L_minibar = miniEjecutiva;
        }
    }
}
