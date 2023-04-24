class Cliente
{
    string Dni{get; set;}
    string Apellido{get; private set;}
    string Nombre{get; private set;}
    DateTime FechaInscripcion{get; private set;}
    int TipoEntrada{get; private set;}
    double TotalAbonado{get;private set;}

    public Cliente(string Dni, string Apellido, string Nombre, DateTime FechaInscripcion, int TipoEntrada, double TotalAbonado)
    {
        dni = Dni;
        apellido = Apellido;
        nombre = Nombre;
        fechaInscripcion = FechaInscripcion;
        tipoEntrada = TipoEntrada;
        totalAbonado = TotalAbonado;
    }
    public bool CambiarEntrada(int TipoEntrada, double TotalAbonado)
    {
        bool cambio = false;
        
        return cambio;
    }
}