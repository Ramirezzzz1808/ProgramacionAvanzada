class ProgramaPrincipal
{
    static void Main(string[] args)
    {
        var config = Configuracion.ObtenerInstancia();

        Console.WriteLine("Ambiente: " + config.Ambiente);
        Console.WriteLine("Cadena de Conexión: " + config.ConexionBD);
    }
}
