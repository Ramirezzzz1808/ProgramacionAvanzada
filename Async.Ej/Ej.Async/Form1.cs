using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej.Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async Task ObtenerDatosAsync()
        {
            // Simula una tarea larga
            var datos = await ObtenerDatosDeServidorAsync();

            // Actualizar la UI con los datos obtenidos
            miLabel.Text = datos;
        }

        private async Task<string> ObtenerDatosDeServidorAsync()
        {
            await Task.Delay(2000); // Simula un retraso
            return "Datos descargados";
        }
        private void label1_click(object sender, EventArgs e)
        {

        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await ObtenerDatosAsync();  
        }



    }
}



