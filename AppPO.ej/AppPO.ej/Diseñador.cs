using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPO.ej
{
    public class Diseñador : Empleado

    {

        public override void RealizarTrabajo()

        {

            Console.WriteLine($"{Nombre} está diseñando.");

        }

    }
}
