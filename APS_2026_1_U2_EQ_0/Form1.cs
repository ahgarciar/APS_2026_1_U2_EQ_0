using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APS_2026_1_U2_EQ_0.Class_Definitions;

namespace APS_2026_1_U2_EQ_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Tipo de dato abstracto
            Gato gato; //declaracion del objeto

            gato = new Gato();

            gato.color = "Naranja";

            gato.Nombre("Gatito");

            string n = gato.Nombre();

            txt_nombre.Text = n;

            Console.WriteLine();



        }
    }
}
