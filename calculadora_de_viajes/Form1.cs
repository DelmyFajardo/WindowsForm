using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_viajes
{
    public partial class Form1 : Form
    {
        private int tiempoTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTiempoTotal_Click(object sender, EventArgs e)
        { //ejemplo: Un objeto  que parte con un punto de origen de 5m/s y un punto de destino de 15 m/s
          //mueve con una velocidad constante de 2 m/s'2, ¿Cual es el tiempo recorrido?
            int num1 = int.Parse(txtPuntoOrigen.Text.ToString());
            int num2 = int.Parse(txtPuntoDestino.Text.ToString());
            int num3 = int.Parse(txtVelocidadConstante.Text.ToString());
            tiempoTotal = (num2 - num1) / num3;
           
            MessageBox.Show("El tiempo recorrido es de: "+ tiempoTotal + "s");
        }
    }
}
