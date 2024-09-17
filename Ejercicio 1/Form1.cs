using Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        private TiradaDeDado tirarDados;

        public Form1()
        {
            InitializeComponent();
            tirarDados = new TiradaDeDado();
        }


        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            // Hace la tirada correspondiente
            var (dado1, dado2, suma) = tirarDados.Tirar();

            // Resultados
            lblDado1.Text = $"Dado 1: {dado1}";
            lblDado2.Text = $"Dado 2: {dado2}";
            lblSuma.Text = $"Suma: {suma}";

            // Muestra la suma
            MostrarConteoSumas();
        }


        private void MostrarConteoSumas()
        {
            int[] conteoSumas = tirarDados.ObtenerConteoSumas();

            // Muestra el listbox limpio 
            lstContSumas.Items.Clear();
            lstContSumas.Items.Add("Suma\tCantidad");

            for (int i = 0; i < conteoSumas.Length; i++)
            {
                int suma = i + 2;
                int cantidad = conteoSumas[i];
                lstContSumas.Items.Add($"{suma}\t{cantidad}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}