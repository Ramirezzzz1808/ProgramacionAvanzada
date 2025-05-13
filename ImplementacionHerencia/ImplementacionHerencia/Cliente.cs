public class Cliente : Persona
{
    public string CodigoCliente { get; set; }

    public Cliente(string nombre, int edad, string codigoCliente)
        : base(nombre, edad)
    {
        CodigoCliente = codigoCliente;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Cliente: {Nombre}, Edad: {Edad}, Código: {CodigoCliente}");
    }
}
