using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPO.ej
{
    // Clase derivada 

    public class Programador : Empleado

    {

        public override void RealizarTrabajo()

        {

            Console.WriteLine($"{Nombre} está programando.");

        }

    }
}
