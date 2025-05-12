using System;

namespace AppPO.ej
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de empleados
            Empleado[] empleados = new Empleado[]
            {
                new Programador { Nombre = "Carlos" },
                new Diseñador { Nombre = "Lucía" },
                new Empleado { Nombre = "María" }
            };

            // Ejecutar el método RealizarTrabajo para cada uno
            foreach (var empleado in empleados)
            {
                empleado.RealizarTrabajo();
            }

            Console.ReadLine(); // Espera para ver los resultados en consola
        }
    }
}
