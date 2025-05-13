using System;
// CatFactsApp.Presentacion - Form1.c
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumoAPI.Negocio;

namespace ConsumoAPI.Presentacion
{
    public class Form1 : Form
    {
        private Button btnObtener;
        private TextBox txtResultado;
        private Label lblTitulo;
        private CatFactService servicio;

        public Form1()
        {
            this.Text = "Datos Curiosos de Gatos 🐱";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            servicio = new CatFactService();

            lblTitulo = new Label()
            {
                Text = "Presiona el botón para obtener un dato curioso:",
                Location = new Point(20, 20),
                Size = new Size(340, 20)
            };

            btnObtener = new Button()
            {
                Text = "Obtener Dato Curioso",
                Location = new Point(20, 50),
                Size = new Size(200, 30)
            };

            txtResultado = new TextBox()
            {
                Location = new Point(20, 90),
                Size = new Size(340, 80),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            btnObtener.Click += async (sender, e) =>
            {
                btnObtener.Enabled = false;
                txtResultado.Text = "Consultando...";
                string dato = await servicio.ObtenerDatoCurioso();
                txtResultado.Text = dato;
                btnObtener.Enabled = true;
            };

            this.Controls.Add(lblTitulo);
            this.Controls.Add(btnObtener);
            this.Controls.Add(txtResultado);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
