using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosYListas
{
    public partial class Form1 : Form
    {
        // Lista para almacenar elementos 

        private List<string> elementos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }


        // Método para agregar elementos 

        private void btnAgregar_Click(object sender, EventArgs e)

        {

            string nuevoElemento = txtElemento.Text;



            if (!string.IsNullOrWhiteSpace(nuevoElemento))

            {

                elementos.Add(nuevoElemento);

                ActualizarLista();

                txtElemento.Clear();

            }

            else

            {

                MessageBox.Show("Por favor ingresa un elemento válido.");

            }

        }



        // Método para eliminar elementos seleccionados 

        private void btnEliminar_Click(object sender, EventArgs e)

        {

            if (lstElementos.SelectedItem != null)

            {

                elementos.Remove(lstElementos.SelectedItem.ToString());

                ActualizarLista();

            }

            else

            {

                MessageBox.Show("Selecciona un elemento para eliminar.");

            }

        }



        // Método para actualizar ListBox 

        private void ActualizarLista()

        {

            lstElementos.DataSource = null;

            lstElementos.DataSource = elementos;

        }

    }

} 

