
using b_Hotel.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Usuario usu = new Usuario("Juan Andres", 21);
        Habitacion hab = new Habitacion(Habitacion.e_Tipos.Suite, "A1");

        Usuario usu1 = new Usuario("Andres", 23);
        Habitacion hab1 = new Habitacion(Habitacion.e_Tipos.Suite, "C1");

        Usuario usu2 = new Usuario("Juan", 18);
        Habitacion hab2 = new Habitacion(Habitacion.e_Tipos.Sencilla, "E1");
        usu.Crear_Reserva(hab);
        usu.Eliminar_Reserva();

        usu1.Crear_Reserva(hab1);
        usu1.Eliminar_Reserva();

        usu2.Crear_Reserva(hab);
        usu.Crear_Reserva(hab2);

        foreach (Reserva res in usu.Office.L_reservas)
        {
            Console.WriteLine($" Reserva {res.Habreserva.Nom}");
        }

        foreach (Reserva res in usu1.Office.L_reservas)
        {
            Console.WriteLine($" Reserva {res.Habreserva.Nom}");
        }
    }
}