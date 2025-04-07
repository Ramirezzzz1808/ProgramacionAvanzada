using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcepcionesEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            try

            {

                int numero1 = int.Parse(txtNumero1.Text);

                int numero2 = int.Parse(txtNumero2.Text);



                int resultado = numero1 / numero2;



                lblResultado.Text = $"Resultado: {resultado}";

            }

            catch (FormatException)

            {

                MessageBox.Show("Por favor, introduce números válidos.", "Error de Formato",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            catch (DivideByZeroException)

            {

                MessageBox.Show("No es posible dividir entre cero.", "División por cero",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally

            {

                txtNumero1.Clear();

                txtNumero2.Clear();

                txtNumero1.Focus();

            }

        }

    }
}
