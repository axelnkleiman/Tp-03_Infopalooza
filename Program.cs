using System.Collections.Generic;
internal class Program
{
    const int NUMSALIR = 5;
    private static void Main(string[] args)
    {
        Dictionary<string, Cliente> DicCliente = new Dictionary<string, Cliente>();
        int menu;
        do
        {
            menu = IngresarInt("Ingrese un numero del 1 al 5");
            switch(menu)
            {
                case 1:
                Opcion1(DicCliente);
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                default:
                Console.WriteLine("Numero mal ingresado");
                break;
            }
        } while (menu != NUMSALIR);
    }
    static int IngresarInt(string mensaje)
    {
        int num;
        Console.WriteLine(mensaje);
        num = int.Parse(Console.ReadLine());
        return num;
    }
    static string IngresarString(string mensaje)
    {
        string String;
        Console.WriteLine(mensaje);
        String = Console.ReadLine();
        return String;
    }
    static void Opcion1(Dictionary<string, Cliente> DicCliente)
    {
        string dni = IngresarString("Ingrese su dni");
        string nombre = IngresarString("Ingrese su nombre");
        string apellido = IngresarString("Ingrese su apellido");
        DateTime fechaInscripcion = DateTime.Now;
        int tipoEntrada = IngresarInt("Ingrese el tipo de entrada que quiere tener: 1-2-3-4");
        double totalAbonado = 0;
        bool datos = true;
        if(dni.Length != 8)
        {
            datos = false;
        }
        switch(tipoEntrada)
        {
            case 1:
            totalAbonado = 15000;
            break;
            case 2:
            totalAbonado = 30000;
            break;
            case 3:
            totalAbonado = 10000;
            break;
            case 4:
            totalAbonado = 40000;
            break;
            default:
            datos = false;
            break;
        }
        if(datos == true)
        {
            Cliente c1 = new Cliente(dni, nombre, apellido, fechaInscripcion, tipoEntrada, totalAbonado);
            DicCliente.Add(dni, c1);
        }
    }
}