
using b_Hotel.Clases;

internal class Program
{
    private static void Main(string[] args)
    {

        Hotel hotel = Hotel.Obtener_Instancia_Hotel();
        Usuario usuActual;
        List<Habitacion> habs;

        /*
        hotel.Importar();

        usuActual = hotel.Hacer_Login("test", "test");

        var hoy = DateTime.Now;
        var maniana = DateTime.Now.AddDays(5);

        habs = hotel.oficinaHotel.Buscar_Habitaciones_Disponibles(hoy, maniana);
        usuActual.Crear_Reserva(habs[49],hoy.ToString("dd/MM/yyyy"), maniana.ToString("dd/MM/yyyy"));
        Console.WriteLine(habs.Count);

        Console.WriteLine("COMPRA #1");
        usuActual.Comprar_Productos(1,0,0,0,0,0,false);
        Console.WriteLine("COMPRA #2");
        usuActual.Comprar_Productos(1,0,0,0,0,0,false);
        Console.WriteLine("COMPRA #3");
        usuActual.Comprar_Productos(2, 0, 0, 0, 0, 0, false);

        usuActual.Comprar_Comida(1, 0, 0,false);
        usuActual.Comprar_Comida(1, 0, 0,false);
        usuActual.Comprar_Comida(1, 0, 0,false);

        foreach (KeyValuePair<string, string> item in hotel.oficinaHotel.Reporte_Habitaciones())
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        usuActual.Check_In();

        foreach (KeyValuePair<string, string> item in hotel.oficinaHotel.Reporte_Habitaciones())
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        Console.WriteLine("\n\n");
        
        foreach (KeyValuePair<string, string> item in usuActual.Check_Out())
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        foreach (KeyValuePair<string, string> item in hotel.oficinaHotel.Reporte_Habitaciones())
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
        */
        Usuario usu1 = new Huesped("Andres", Usuario.e_tipoID.TI, 131313, 123123123, "Benjumea", "1027892021An", Usuario.e_Nacionalidad.Colombiano);
        Console.WriteLine(usu1.Nombre + " " + usu1.Nacionalidad);


        string entrada = "18/05/2023";
        string salida = "20/05/2023";

        habs = hotel.oficinaHotel.Buscar_Habitaciones_Disponibles(entrada,salida).ToList();

        Habitacion hab1 = habs[31];
        Console.WriteLine(hab1.Id);

        usu1.Crear_Reserva(hab1.Id,entrada,salida);
    }
}