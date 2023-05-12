using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Oficina
    {
        private List<Reserva> l_reservas = new();
        private readonly Recepcion recepcionHotel;

        public Oficina()
        {}

        public List<Reserva> L_reservas { get => l_reservas; }

        internal delegate void delegadoReserva();
        internal event delegadoReserva eventoReserva;

        internal delegate void delegadoRestaurante();
        internal event delegadoRestaurante eventoRestaurante;

        internal delegate void delegadoLavanderia();
        internal event delegadoLavanderia eventoLavanderia;

        internal delegate void delegadoTienda();
        internal event delegadoTienda eventoTienda;

        internal void Informar_Nueva_Reserva(Reserva res)
        {
            try
            {
                if (eventoReserva != null)
                {
                    eventoReserva();

                    Console.WriteLine($"Nueva Reserva, Habitacion {res.Habreserva}");
                    l_reservas.Add(res);
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal void Eliminar_Reserva(Usuario usu)
        {
            try
            {
                if (eventoReserva != null)
                {
                    eventoReserva();
                    foreach (Reserva res in L_reservas)
                    {
                        if (res.UsuarioReserva == usu)
                        {
                            res.Habreserva.Ocupada = false;
                            res.Habreserva.ReservaActual = null;

                            if (res.Habreserva is Habitacion_Ejecutiva)
                            {
                                Habitacion_Ejecutiva eje = res.Habreserva as Habitacion_Ejecutiva;
                                eje.Llenar_MiniBar();
                            }
                            else if (res.Habreserva is Habitacion_Suite)
                            {
                                Habitacion_Suite sui = res.Habreserva as Habitacion_Suite;
                                sui.Llenar_MiniBar();
                            }

                            L_reservas.Remove(res);
                            Console.WriteLine($"Cancelando Reserva de {usu}");
                        }
                    }
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal void Agregar_Comida_Reserva(Usuario usu, List<Comida> listaComidas, bool alCuarto)
        {
            try
            {
                if (eventoRestaurante != null)
                {
                    eventoRestaurante();
                    foreach (Reserva res in L_reservas)
                    {
                        if (res.UsuarioReserva == usu)
                        {
                            foreach (Comida comida in listaComidas)
                            {
                                res.ResComidas.Add(comida);
                            }

                            if (alCuarto)
                                res.Nro_ServiciosCuarto++;
                        }
                    }
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal void Agregar_Servicios_Reserva(Usuario usu, List<Servicio> listaServicios, bool alCuarto)
        {
            try
            {
                if (eventoLavanderia != null)
                {
                    eventoLavanderia();
                    foreach (Reserva res in L_reservas)
                    {
                        if (res.UsuarioReserva == usu)
                        {
                            foreach (Servicio serv in listaServicios)
                            {
                                res.ResServicios.Add(serv);
                            }

                            if (alCuarto)
                                res.Nro_ServiciosCuarto++;
                        }
                    }
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal void Agregar_Productos_Reserva(Usuario usu, List<Producto> listaProductos, bool alCuarto)
        {
            List<Producto> l_aux = listaProductos;
            try
            {
                if (eventoTienda != null)
                {
                    eventoTienda();
                    foreach (Reserva res in L_reservas)
                    {
                        if (res.UsuarioReserva == usu)
                        {
                            if (res.Habreserva is Habitacion_Ejecutiva)
                            {
                                Habitacion_Ejecutiva eje = res.Habreserva as Habitacion_Ejecutiva;

                                foreach (Producto productoComprar in l_aux)
                                {
                                    foreach (Producto productoMini in eje.L_minibar)
                                    {
                                        if (productoComprar.Type == productoMini.Type)
                                        {
                                            res.ResProductos.Add(productoComprar);
                                            l_aux.Remove(productoComprar);
                                            eje.L_minibar.Remove(productoMini);
                                            eje.Tiene_Producto();
                                        }
                                    }
                                }

                                if (!(l_aux.Count == 0))
                                {
                                    foreach (Producto producto in l_aux)
                                    {
                                        res.ResProductos.Add(producto);
                                    }
                                }
                            }

                            else if (res.Habreserva is Habitacion_Suite)
                            {
                                Habitacion_Suite sui = res.Habreserva as Habitacion_Suite;

                                foreach (Producto productoComprar in l_aux)
                                {
                                    foreach (Producto productoMini in sui.L_minibar)
                                    {
                                        if (productoComprar.Type == productoMini.Type)
                                        {
                                            res.ResProductos.Add(productoComprar);
                                            l_aux.Remove(productoComprar);
                                            sui.L_minibar.Remove(productoMini);
                                            sui.Tiene_Producto();
                                        }
                                    }
                                }

                                if (!(l_aux.Count == 0))
                                {
                                    foreach (Producto producto in l_aux)
                                    {
                                        res.ResProductos.Add(producto);
                                    }
                                }
                            }

                            else
                            {
                                foreach (Producto producto in l_aux)
                                {
                                    res.ResProductos.Add(producto);
                                }
                            }

                            if (alCuarto)
                                res.Nro_ServiciosCuarto++;

                        }
                    }
                }
                else throw new Exception("NO SUSCRITO");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
