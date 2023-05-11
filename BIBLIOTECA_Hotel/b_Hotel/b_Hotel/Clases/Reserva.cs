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
        private Usuario usuarioReserva;

        private List<Producto> resProductos;
        private List<Comida> resComidas;
        private List<Servicio> resServicios;
        private int nro_ServiciosCuarto;

        public Reserva(Habitacion hab, Usuario usu)
        {
            Habreserva = hab;
            UsuarioReserva = usu;
            
            resProductos = new();
            resComidas = new(); 
            resServicios = new(); 
            nro_ServiciosCuarto = new(); 
        }

        public Habitacion Habreserva { get => habreserva; set => habreserva = value; }
        public List<Producto> ResProductos { get => resProductos; set => resProductos = value; }
        public List<Comida> ResComidas { get => resComidas; set => resComidas = value; }
        public List<Servicio> ResServicios { get => resServicios; set => resServicios = value; }
        public Usuario UsuarioReserva { get => usuarioReserva; set => usuarioReserva = value; }
        public int Nro_ServiciosCuarto { get => nro_ServiciosCuarto; set => nro_ServiciosCuarto = value; }
    }
}
