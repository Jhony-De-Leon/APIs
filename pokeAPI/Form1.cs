using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace pokeAPI
{
    public partial class Form1 : Form
    {
        private HttpClient cliente = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            string pokemonName = textBox1.Text.ToLower();
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {
                string reponse = await cliente.GetStringAsync(url);
                JObject json = JObject.Parse(reponse);

                lblPeso.Text = $"Peso: {json["weight"]}";
                lblAltura.Text = $"Altura: {json["height"]}";
                lblTipo.Text = $"Tipo: {json["types"][0]["type"]["name"]}";
                string imagenurl = json["sprites"]["front_default"]?.ToString();
                pictureBox1.Load(imagenurl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la informacion del pokemon: " + ex.Message);
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            lblPeso.Text = "Peso:";
            lblAltura.Text = "Altura:";
            lblTipo.Text = "Tipo:";

            pictureBox1.Image = null;
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string peso = lblPeso.Text;
            string altura = lblAltura.Text;
            string tipo = lblTipo.Text;
            string imagenUrl = pictureBox1.ImageLocation;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Busca un Pokémon antes de exportar!!!!");
                return;
            }

            string texto = $"{nombre}\n{peso}\n{altura}\n{tipo}\nImagen: {imagenUrl}";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo de texto (*.txt)|*.txt";
                saveFileDialog.Title = "Guardar información del Pokémon";
                saveFileDialog.FileName = "pokemon_info.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, texto);
                        MessageBox.Show("¡Información exportada con éxito!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                    }
                }
            }
        }

        private async void buttonCatAPI_Click(object sender, EventArgs e)
        {
            string url = "https://api.thecatapi.com/v1/images/search";

            try
            {
                string response = await cliente.GetStringAsync(url);
                JArray json = JArray.Parse(response);
                string imageUrl = json[0]["url"].ToString();

                pictureBox1.Load(imageUrl);
                lblPeso.Text = "Peso:";
                lblAltura.Text = "Altura:";
                lblTipo.Text = "Tipo: Felino (Gato)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la imagen del gato: " + ex.Message);
            }
        }
    }
}
