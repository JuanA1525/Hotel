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
    internal class Habitacion : I_MiniBar
    {
        private int precioSencilla = 200000;
        private int precioEjecutiva = 350000;
        private int precioSuite = 500000;

        private List<Producto> miniEjecutiva = new List<Producto>
                {
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.Licor),
                    new Producto(Producto.e_tipos_producto.KitAseo),
                    new Producto(Producto.e_tipos_producto.Gaseosa),
                    new Producto(Producto.e_tipos_producto.Gaseosa)
                };

        private List<Producto> miniSuite = new List<Producto>
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

        public enum e_Tipos { Sencilla , Ejecutiva , Suite }
        
        private int precioNoche;
        private List<Producto>? l_minibar;
        private e_Tipos tipoHabitacion;
        private string nom;

        private bool ocupada;
        private Reserva? reservaActual;

        public bool Ocupada { get => ocupada; set => ocupada = value; }
        public Reserva? ReservaActual { get => reservaActual; set => reservaActual = value; }

        public Habitacion(e_Tipos tipo, string nombre)
        {
            if (tipo.Equals(e_Tipos.Sencilla))
            {
                precioNoche = precioSencilla;
                tipoHabitacion = tipo;
                l_minibar = null;
            }
            else if (tipo.Equals(e_Tipos.Ejecutiva))
            {
                precioNoche = precioEjecutiva;
                tipoHabitacion = tipo;
                l_minibar = miniEjecutiva;
            }
            else if (tipo.Equals(e_Tipos.Suite))
            {
                precioNoche = precioSuite;
                tipoHabitacion = tipo;
                l_minibar = miniSuite;
            }

            Ocupada = false;
            ReservaActual = null; 
            nom = nombre;
        }

        public void Llenar_MiniBar()
        {
            if (tipoHabitacion.Equals(e_Tipos.Sencilla))
            {
                l_minibar = null;
            }
            else if (tipoHabitacion.Equals(e_Tipos.Ejecutiva))
            {
                l_minibar = miniEjecutiva;
            }
            else if (tipoHabitacion.Equals(e_Tipos.Suite))
            {
                l_minibar = miniSuite;
            }
        }
    }
}
