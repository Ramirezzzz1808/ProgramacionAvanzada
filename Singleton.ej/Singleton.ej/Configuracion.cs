public class Configuracion
{
    // Campo estático para la instancia única
    private static Configuracion instancia = null;

    // Objeto para hacer thread-safe el acceso
    private static readonly object candado = new object();

    // Propiedades de configuración
    public string ConexionBD { get; private set; }
    public string Ambiente { get; private set; }

    // Constructor privado
    private Configuracion()
    {
        // Inicialización de configuraciones
        ConexionBD = "Server=localhost;Database=MiApp;User Id=admin;Password=1234;";
        Ambiente = "Producción";
    }

    // Método público para obtener la instancia
    public static Configuracion ObtenerInstancia()
    {
        if (instancia == null)
        {
            lock (candado)
            {
                if (instancia == null)
                {
                    instancia = new Configuracion();
                }
            }
        }
        return instancia;
    }
}
