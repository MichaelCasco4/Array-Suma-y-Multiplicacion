using Ejercicio_3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        //Aqui se almacenan las ventas que se hayan hecho
        private List<Venta> ventas = new List<Venta>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {

            int vendedor = int.Parse(txtVendedor.Text); //Obtenemos el valor ingresado
            int producto = int.Parse(txtProducto.Text);
            float valorVenta = float.Parse(txtVenta.Text);


            if (vendedor >= 1 && vendedor <= 4 && producto >= 1 && producto <= 5) //Validacion "IF"
            {

                Venta nuevaVenta = new Venta(vendedor, producto, valorVenta); //Aqui se crea una nueva lista de venta 
                ventas.Add(nuevaVenta);

                MessageBox.Show("Venta agregada exitosamente."); //Mensajes de error notificados
            }
            else
            {
                MessageBox.Show("Error: Vendedor o producto fuera de rango.");
            }

            // Funcion de limpieza de liatbox
            txtVendedor.Clear();
            txtProducto.Clear();
            txtVenta.Clear();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {

            float[,] resumenVentas = new float[5, 4]; //Este es un arreglo que resume las ventas (Lo investigue en una IA)


            foreach (Venta venta in ventas)
            {
                resumenVentas[venta.Producto - 1, venta.Vendedor - 1] += venta.ValorVenta;
            }

            //Reporte Generado(Me guie de una IA)
            lstReporte.Items.Clear();
            lstReporte.Items.Add("Producto/Vendedor   1       2       3       4   | Total Producto");

            for (int producto = 0; producto < 5; producto++)
            {
                float totalProducto = 0;
                string linea = $"Producto {producto + 1}       ";

                for (int vendedor = 0; vendedor < 4; vendedor++)
                {
                    linea += $"{resumenVentas[producto, vendedor],8:F2} ";
                    totalProducto += resumenVentas[producto, vendedor];
                }

                linea += $"| {totalProducto,8:F2}";
                lstReporte.Items.Add(linea);
            }


            lstReporte.Items.Add("----------------------------------------------------------");
            string lineaTotales = "Total Vendedor     ";
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                float totalVendedor = 0;
                for (int producto = 0; producto < 5; producto++)
                {
                    totalVendedor += resumenVentas[producto, vendedor];
                }
                lineaTotales += $"{totalVendedor,8:F2} ";
            }
            lstReporte.Items.Add(lineaTotales);
        }
    }
}