using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                double num1 = Convert.ToDouble(textBox1.Text);

                double num2 = Convert.ToDouble(textBox2.Text);

                double suma = num1 + num2;

                label3.Text = "Resultado: " + suma.ToString();

            }

            catch (FormatException)

            {

                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");

            }

        }
    }
    }

