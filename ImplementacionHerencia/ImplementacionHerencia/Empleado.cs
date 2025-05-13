public class Empleado : Persona
{
    public string Puesto { get; set; }

    public Empleado(string nombre, int edad, string puesto)
        : base(nombre, edad)
    {
        Puesto = puesto;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Empleado: {Nombre}, Edad: {Edad}, Puesto: {Puesto}");
    }
}

