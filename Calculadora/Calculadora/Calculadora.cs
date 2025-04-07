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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        private void Boton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void BotonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = new DataTable().Compute(textBox1.Text, null).ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }
        private void LimpiarTextBox()
        {
            textBox1.Clear(); 
        }


        private void Resta_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Boton_Click((Button)sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
           BotonIgual_Click((Button)sender, e); 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
    }
}
