using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImplementacionHerenciaForms
{
    public class Form1 : Form
    {
        private ComboBox cmbTipoPersona;
        private TextBox txtNombre, txtEdad, txtExtra;
        private Label lblTipo, lblNombre, lblEdad, lblExtra;
        private Button btnAgregar;
        private ListBox lstPersonas;

        private List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InicializarComponentes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarComponentes()
        {
            // Formulario
            this.Text = "Personas - Herencia y Polimorfismo";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Labels
            lblTipo = new Label() { Text = "Tipo:", Location = new Point(20, 20), AutoSize = true };
            lblNombre = new Label() { Text = "Nombre:", Location = new Point(20, 60), AutoSize = true };
            lblEdad = new Label() { Text = "Edad:", Location = new Point(20, 100), AutoSize = true };
            lblExtra = new Label() { Text = "Puesto:", Location = new Point(20, 140), AutoSize = true };

            // ComboBox
            cmbTipoPersona = new ComboBox() { Location = new Point(100, 20), Width = 150 };
            cmbTipoPersona.Items.AddRange(new string[] { "Empleado", "Cliente" });
            cmbTipoPersona.SelectedIndex = 0;
            cmbTipoPersona.SelectedIndexChanged += CmbTipoPersona_SelectedIndexChanged;

            // TextBoxes
            txtNombre = new TextBox() { Location = new Point(100, 60), Width = 150 };
            txtEdad = new TextBox() { Location = new Point(100, 100), Width = 150 };
            txtExtra = new TextBox() { Location = new Point(100, 140), Width = 150 };

            // Botón
            btnAgregar = new Button() { Text = "Agregar", Location = new Point(100, 180), Width = 150 };
            btnAgregar.Click += BtnAgregar_Click;

            // ListBox
            lstPersonas = new ListBox() { Location = new Point(270, 20), Size = new Size(200, 300) };

            // Agregar controles al formulario
            this.Controls.Add(lblTipo);
            this.Controls.Add(lblNombre);
            this.Controls.Add(lblEdad);
            this.Controls.Add(lblExtra);
            this.Controls.Add(cmbTipoPersona);
            this.Controls.Add(txtNombre);
            this.Controls.Add(txtEdad);
            this.Controls.Add(txtExtra);
            this.Controls.Add(btnAgregar);
            this.Controls.Add(lstPersonas);
        }

        private void CmbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPersona.SelectedItem.ToString() == "Empleado")
                lblExtra.Text = "Puesto:";
            else
                lblExtra.Text = "Código Cliente:";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            bool edadValida = int.TryParse(txtEdad.Text, out int edad);
            string extra = txtExtra.Text;

            if (string.IsNullOrWhiteSpace(nombre) || !edadValida || string.IsNullOrWhiteSpace(extra))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
                return;
            }

            Persona persona;

            if (cmbTipoPersona.SelectedItem.ToString() == "Empleado")
            {
                persona = new Empleado(nombre, edad, extra);
            }
            else
            {
                persona = new Cliente(nombre, edad, extra);
            }

            personas.Add(persona);
            ActualizarLista();
            LimpiarCampos();
        }

        private void ActualizarLista()
        {
            lstPersonas.Items.Clear();
            foreach (var persona in personas)
            {
                lstPersonas.Items.Add(persona.MostrarInformacion());
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtExtra.Clear();
            txtNombre.Focus();
        }
    }
}
