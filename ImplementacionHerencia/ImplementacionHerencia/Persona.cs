public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método común que será sobrescrito
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

