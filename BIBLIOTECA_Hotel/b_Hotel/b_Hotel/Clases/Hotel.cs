using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Hotel
    {
        private static Hotel instanciaHotel;
        
        public Oficina oficinaHotel { get; private set; }
        public List<Usuario> l_usuarios { get; private set; }
        public Lavanderia lavanderiaHotel{ get; private set; }
        public Tienda tiendaHotel{ get; private set; }
        public Restaurante restauranteHotel { get; private set; }

        private Hotel()
        { 
            restauranteHotel = new Restaurante();
            l_usuarios = new List<Usuario>();
            lavanderiaHotel = new Lavanderia();
            tiendaHotel = new Tienda();
            oficinaHotel = new Oficina();
        }

        public static Hotel Obtener_Instancia_Hotel()
        {
            if (instanciaHotel == null)
            {
                instanciaHotel = new Hotel();
            }

            return instanciaHotel;
        }

    }
}
