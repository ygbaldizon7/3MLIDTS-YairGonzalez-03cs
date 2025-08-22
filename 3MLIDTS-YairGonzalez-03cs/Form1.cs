using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_YairGonzalez_03cs
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Presiono el boton de CALCULAR");
            if (tbCelsius.Text != ""||tbFahrenheit.Text != "" || tbKevin.Text !="") {
                //MessageBox.Show("Celsius");
                if (!string.IsNullOrEmpty(tbCelsius.Text)) {
                    MessageBox.Show("Celsius");
                    //Obtenemos el valor del TextBos Celsius y se convierte de string a float
                    float Ce = float.Parse(tbCelsius.Text);
                    float Fa = (Ce * 9.0f / 5.0f) + 32;
                    tbFahrenheit.Text = Fa.ToString();
                    float Ke = Ce + 273.15f;
                    tbKevin.Text = Ke.ToString();
                } else if (!string.IsNullOrEmpty(tbFahrenheit.Text)) {
                    MessageBox.Show("Fahrenheit");
                    float Fa = float.Parse(tbFahrenheit.Text);
                    float Ce = (Fa - 32) *5.0f / 9.0f;
                    tbCelsius.Text = Ce.ToString();
                    float Ke = Ce + 273.15f;
                    tbKevin.Text = Ke.ToString();
                } else if (!string.IsNullOrEmpty(tbKevin.Text)) {
                    MessageBox.Show("Kelvin");
                    float Ke = float.Parse(tbKevin.Text);
                    float Ce = Ke -273.15f;
                    tbCelsius.Text = Ce.ToString();
                    float Fa = (Ce * 9.0f / 5.0f) + 32;
                    tbFahrenheit.Text = Fa.ToString();
                }
            }
            else {
                MessageBox.Show("Ingrese valores para el calculo de la temperatura");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presiono el boton de LIMPIAR");
            //tbCelsius.Text = "0.0";
            //tbFahrenheit.Text = "0.0";
            //tbKevin.Text = "0.0";
            tbCelsius.Clear();
            tbFahrenheit.Clear();
            tbKevin.Clear();
        }
    }
}
