using b_Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Habitacion_Ejecutiva : Habitacion , I_MiniBar
    {
        public Habitacion_Ejecutiva() : base()
        {
            Ocupada = false;
            ReservaActual = null;
            PrecioNoche = precioEjecutiva;

            Llenar_MiniBar();
        }

        public void Llenar_MiniBar()
        {
            L_minibar = miniEjecutiva;
        }
    }
}
