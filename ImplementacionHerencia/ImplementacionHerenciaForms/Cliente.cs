public class Cliente : Persona
{
    public string CodigoCliente { get; set; }

    public Cliente(string nombre, int edad, string codigoCliente)
        : base(nombre, edad)
    {
        CodigoCliente = codigoCliente;
    }

    public override string MostrarInformacion()
    {
        return $"[Cliente] Nombre: {Nombre}, Edad: {Edad}, Código: {CodigoCliente}";
    }
}
