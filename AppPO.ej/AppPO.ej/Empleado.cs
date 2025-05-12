using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPO.ej
{
    // Clase base 

    public class Empleado

    {

        public string Nombre { get; set; }



        public virtual void RealizarTrabajo()

        {

            Console.WriteLine($"{Nombre} está trabajando.");

        }

    }





    } 