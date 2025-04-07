using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracion2Framewokr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Cargar enum en ComboBox 
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoPedido));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Obtener valor seleccionado del ComboBox 
            EstadoPedido estadoSeleccionado = (EstadoPedido)cmbEstado.SelectedItem;


            switch (estadoSeleccionado)
            {
                case EstadoPedido.Pendiente:
                    lblResultado.Text = "Tu pedido está pendiente.";
                    break;
                case EstadoPedido.Procesando:
                    lblResultado.Text = "Tu pedido está siendo procesado.";
                    break;
                case EstadoPedido.Enviado:
                    lblResultado.Text = "Tu pedido ha sido enviado.";
                    break;
                case EstadoPedido.Entregado:
                    lblResultado.Text = "Tu pedido fue entregado.";
                    break;
                case EstadoPedido.Cancelado:
                    lblResultado.Text = "Tu pedido fue cancelado.";
                    break;
                default:
                    lblResultado.Text = "Estado desconocido.";
                    break;
            }
        }
    }
} 
        
