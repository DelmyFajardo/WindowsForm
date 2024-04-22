using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ConsumoDeCombustible
{
    public partial class Form1 : Form
    {
        private decimal Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDistanciaRec_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRendimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltotal.Text = Total.ToString(); 
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {  // ejemplo: Un vehiculo recorrio 190 km,y se estima que  tuvo un  redimiento de 38 km/gal
           // ¿cuantos galones de gasolina gasto en total ?  R// 5 galones
            decimal num1 = decimal.Parse(txtDistanciaRec.Text.ToString());
            decimal num2 = decimal.Parse(txtRendimiento.Text.ToString());
            Total = (num1 / num2);
            lbltotal.Text = Total.ToString();
           

        }
    }
}
 
