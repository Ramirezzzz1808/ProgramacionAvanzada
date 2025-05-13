public class Empleado : Persona
{
    public string Puesto { get; set; }

    public Empleado(string nombre, int edad, string puesto)
        : base(nombre, edad)
    {
        Puesto = puesto;
    }

    public override string MostrarInformacion()
    {
        return $"[Empleado] Nombre: {Nombre}, Edad: {Edad}, Puesto: {Puesto}";
    }
}
