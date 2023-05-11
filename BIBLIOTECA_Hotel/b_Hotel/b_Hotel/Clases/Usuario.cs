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
        public enum e_tipoID { CC , TI , PA , CE }
        private bool tieneReserva;
        private Hotel hotel;

        private string nombre;
        private e_tipoID tipoID;
        private short nroDoc;
        private short telefono;
        private string usuarioLogin;
        private string contrasenia;

        public string Nombre { get => nombre; set => nombre = value; }
        public e_tipoID TipoID { get => tipoID; set => tipoID = value; }
        public short NroDoc { get => nroDoc; set => nroDoc = value; }
        public short Telefono { get => telefono; set => telefono = value; }
        public string UsuarioLogin { get => usuarioLogin; set => usuarioLogin = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }

        public Usuario(string nom, e_tipoID tipoid, short documento, short tel, string usu, string contra)
        {
            Nombre = nom;
            TipoID = tipoid;
            NroDoc = documento;
            Telefono = tel;
            UsuarioLogin = usu;
            Contrasenia = contra;

            tieneReserva = false;
            hotel = Hotel.Obtener_Instancia_Hotel();
        }

        public void Event_Handler_Reservas()
        {
            Console.WriteLine("Procesando Reserva");
        }

        public void Crear_Reserva(Habitacion hab)
        {
            Reserva reservaUsu = new Reserva(hab, this);
            Oficina office = hotel.oficinaHotel;
            try
            {
                if (!tieneReserva)
                {
                    reservaUsu.Habreserva.ReservaActual = reservaUsu;
                    reservaUsu.Habreserva.Ocupada = true;

                    office.eventoReserva += Event_Handler_Reservas;
                    office.Informar_Nueva_Reserva(reservaUsu);
                    office.eventoReserva -= Event_Handler_Reservas;
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
            Oficina office = hotel.oficinaHotel;
            try
            {
                if (tieneReserva)
                {
                    office.eventoReserva += Event_Handler_Reservas;
                    office.Eliminar_Reserva(this);
                    office.eventoReserva -= Event_Handler_Reservas;
                }
                else
                    Console.WriteLine("Usted ya tiene Reserva");
            }
            catch (Exception error)
            {
                throw new Exception("Error en crear reserva " + error);
            }
        }
        public void Comprar_Comida(int nro_Des, int nro_Alm, int nro_Cena, bool alCuarto)
        {
            try
            {
                List<Comida> lista = new List<Comida>();

                for (int i = 0; i < nro_Alm; i++)
                {
                    lista.Add(new Comida(Comida.e_tipos_comida.Almuerzo));
                }

                for (int i = 0; i < nro_Des; i++)
                {
                    lista.Add(new Comida(Comida.e_tipos_comida.Desayuno));
                }

                for (int i = 0; i < nro_Cena; i++)
                {
                    lista.Add(new Comida(Comida.e_tipos_comida.Cena));
                }

                hotel.restauranteHotel.Vender_Comida(lista, alCuarto, this);
            }
            catch
            {
                throw new Exception("Error en Comprar Comida");
            }
        }
        public void Solicitar_Servicio(int nro_Lavadas, int nro_Planchadas, bool alCuarto)
        {
            try
            {
                List<Servicio> lista = new List<Servicio>();

                for (int i = 0; i < nro_Lavadas; i++)
                {
                    lista.Add(new Servicio(Servicio.e_tipos_servicio.Lavada));
                }

                for (int i = 0; i < nro_Planchadas; i++)
                {
                    lista.Add(new Servicio(Servicio.e_tipos_servicio.Planchada));
                }

                hotel.lavanderiaHotel.Lavar_Planchar(lista, alCuarto, this);
            }
            catch
            {
                throw new Exception("Error en Comprar Comida");
            }
        }
        public void Comprar_Productos(int nro_Gaseosa, int nro_Agua, int nro_Vino, int nro_Licor, int nro_Bata, int nro_KitAseo, bool alCuarto)
        {
            try
            {
                List<Producto> lista = new List<Producto>();

                for (int i = 0; i < nro_Agua; i++)
                {
                    lista.Add(new Producto(Producto.e_tipos_producto.Agua));
                }

                for (int i = 0; i < nro_Bata; i++)
                {
                    lista.Add(new Producto(Producto.e_tipos_producto.Bata));
                }

                for (int i = 0; i < nro_Gaseosa; i++)
                {
                    lista.Add(new Producto(Producto.e_tipos_producto.Gaseosa));
                }

                for (int i = 0; i < nro_KitAseo; i++)
                {
                    lista.Add(new Producto(Producto.e_tipos_producto.KitAseo));
                }

                for (int i = 0; i < nro_Licor; i++)
                {
                    lista.Add(new Producto(Producto.e_tipos_producto.KitAseo));
                }

                for (int i = 0; i < nro_Vino; i++)
                {
                    lista.Add(new Producto(Producto.e_tipos_producto.Vino));
                }

                hotel.tiendaHotel.Vender_Productos(lista, alCuarto, this);
            }
            catch
            {
                throw new Exception("Error en Comprar Comida");
            }
        }
    }
}
