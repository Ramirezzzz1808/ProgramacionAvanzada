class Program
{
    static void Main(string[] args)
    {
        List<Persona> personas = new List<Persona>
        {
            new Empleado("Carlos", 35, "Ingeniero"),
            new Cliente("Ana", 28, "C123"),
            new Empleado("Luisa", 40, "Gerente"),
            new Cliente("Pedro", 22, "C456")
        };

        foreach (Persona p in personas)
        {
            p.MostrarInformacion();  // Comportamiento polimórfico
        }
    }
}
