using b_Hotel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public abstract class Habitacion
    {
        internal int precioSencilla = 200000;
        internal int precioEjecutiva = 350000;
        internal int precioSuite = 500000;

        internal readonly List<Producto> miniEjecutiva = new ()
                {
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.KitAseo),
                    new Producto(Producto.e_tipos_producto.Gaseosa),
                    new Producto(Producto.e_tipos_producto.Gaseosa)
                };

        internal readonly List<Producto> miniSuite = new ()
                {
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.KitAseo),
                    new Producto(Producto.e_tipos_producto.KitAseo),
                    new Producto(Producto.e_tipos_producto.KitAseo),
                    new Producto(Producto.e_tipos_producto.Gaseosa),
                    new Producto(Producto.e_tipos_producto.Gaseosa),
                    new Producto(Producto.e_tipos_producto.Gaseosa),
                    new Producto(Producto.e_tipos_producto.Gaseosa),
                    new Producto(Producto.e_tipos_producto.Bata),
                    new Producto(Producto.e_tipos_producto.Bata)
                };
        

        private int precioNoche;
        private List<Producto>? l_minibar;
        private bool ocupada;
        private Reserva? reservaActual;

        public bool Ocupada { get => ocupada; set => ocupada = value; }
        public Reserva? ReservaActual { get => reservaActual; set => reservaActual = value; }
        public int PrecioNoche { get => precioNoche; set => precioNoche = value; }
        public List<Producto>? L_minibar { get => l_minibar; set => l_minibar = value; }
    }
}
