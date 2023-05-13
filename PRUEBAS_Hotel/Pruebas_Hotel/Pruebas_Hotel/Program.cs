
using b_Hotel.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Hotel hotel = Hotel.Obtener_Instancia_Hotel();
        Usuario usuActual;
        List<Habitacion> habs;

        hotel.Importar();

        usuActual = hotel.Hacer_Login("test", "test");

        var hoy = DateTime.Now;
        var maniana = DateTime.Now.AddDays(5);

        habs = hotel.oficinaHotel.Buscar_Habitaciones_Disponibles(hoy, maniana);
        usuActual.Crear_Reserva(habs[2],hoy.ToString("dd/MM/yyyy"), maniana.ToString("dd/MM/yyyy"));
        Console.WriteLine(habs.Count);

        hoy = DateTime.Now.AddDays(10);
        maniana = DateTime.Now.AddDays(15);

        habs = hotel.oficinaHotel.Buscar_Habitaciones_Disponibles(hoy, maniana);
        usuActual.Crear_Reserva(habs[2], hoy.ToString("dd/MM/yyyy"), maniana.ToString("dd/MM/yyyy"));
        Console.WriteLine(habs.Count);
    }
}