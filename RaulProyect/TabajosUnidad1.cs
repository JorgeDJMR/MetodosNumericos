using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RaulProyect
{
    public partial class TabajosUnidad1 : Form
    {
        public TabajosUnidad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"MapaconceptualRaulitoMoment.pdf";
            abrir.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Problemario1.pdf";
            abrir.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuGeneral ob2 = new MenuGeneral();
            ob2.Show();
        }
    }
}
