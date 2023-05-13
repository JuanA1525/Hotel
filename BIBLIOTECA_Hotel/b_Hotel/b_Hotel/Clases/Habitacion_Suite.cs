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
            Reservada = false;
            ReservaActual = null;
            PrecioNoche = precioSuite;
            TieneMini = true;
            L_minibar = miniEjecutiva;
        }

        public void Llenar_MiniBar()
        {
            L_minibar = miniEjecutiva;
            Console.WriteLine("ReLlenando MiniBar");
        }
        public void Tiene_Producto()
        {
            try
            {
                foreach (Producto.e_tipos_producto tipo in tiposEje)
                {
                    bool found = false;
                    foreach (Producto producto in L_minibar)
                    {
                        if (producto.Type == tipo)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        Llenar_MiniBar();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en Tiene Producto Sui");
            }
        }

    }
}
