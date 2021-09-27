using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, promedio;
            string condicion;

            nota_1 = Double.Parse(txtNota1.Text);
            nota_2 = Double.Parse(txtNota2.Text);
            nota_3 = Double.Parse(txtNota3.Text);

            promedio = (nota_1 + nota_2 + nota_3)/3;

            if (promedio <=5)
            {
                condicion = "Reprobado";
                txtPromedio.Text = promedio.ToString("N2");
                txtCondicion.Text = condicion;
            }
            else if  (promedio > 6 && promedio <= 10);
            {
                condicion = "Aprobado";
                txtPromedio.Text = promedio.ToString("N2");
                txtCondicion.Text = condicion;
            }
        }
    }
}
