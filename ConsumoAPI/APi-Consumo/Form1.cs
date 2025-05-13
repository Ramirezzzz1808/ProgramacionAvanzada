using APi_Consumo.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APi_Consumo.Presentacion
{
    public class Form1 : Form
    {
        private Button btnCargar;
        private ComboBox cboPaises;
        private PictureBox picBandera;
        private TextBox txtInfo;
        private CountryService _service;

        public Form1()
        {
            this.Text = "Información de Países 🌎";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            _service = new CountryService();

            btnCargar = new Button()
            {
                Text = "Cargar Países",
                Location = new Point(20, 20),
                Size = new Size(120, 30)
            };

            cboPaises = new ComboBox()
            {
                Location = new Point(150, 20),
                Size = new Size(300, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            picBandera = new PictureBox()
            {
                Location = new Point(20, 60),
                Size = new Size(150, 100),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            txtInfo = new TextBox()
            {
                Location = new Point(20, 170),
                Size = new Size(430, 150),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };

            btnCargar.Click += async (s, e) => await CargarPaises();

            cboPaises.SelectedIndexChanged += (s, e) =>
            {
                var pais = (APi_Consumo.Datos.Country)cboPaises.SelectedItem;
                txtInfo.Text =
                    $"🌐 País: {pais.name.common}\r\n" +
                    $"🏛 Capital: {string.Join(", ", pais.capital ?? new List<string>())}\r\n" +

                    $"🌍 Región: {pais.region}\r\n" +
                    $"👥 Población: {pais.population:N0}";

                picBandera.LoadAsync(pais.flags.png);
            };

            Controls.Add(btnCargar);
            Controls.Add(cboPaises);
            Controls.Add(picBandera);
            Controls.Add(txtInfo);
        }

        private async Task CargarPaises()
        {
            cboPaises.Items.Clear();
            txtInfo.Clear();
            var lista = await _service.ObtenerPaisesAsync();
            var ordenados = lista.OrderBy(p => p.name.common).ToList();

            foreach (var pais in ordenados)
                cboPaises.Items.Add(pais);

            cboPaises.DisplayMember = "name.common";
        }
    }
}

