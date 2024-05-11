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
    public partial class Integracion : Form
    {
        public Integracion()
        {
            InitializeComponent();
        }


        private void btnDif_Click(object sender, EventArgs e)
        {
            ReglaDelTrapecio abrirMenu4 = new ReglaDelTrapecio();
            this.Hide();
            abrirMenu4.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUnidad4 retrocede = new MenuUnidad4();
            retrocede.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReglaDeSimpsonUnTercio abrirMenu4 = new ReglaDeSimpsonUnTercio();
            this.Hide();
            abrirMenu4.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReglaDeSimpsonUnTercioPorIntervalos abrirMenu4 = new ReglaDeSimpsonUnTercioPorIntervalos();
            this.Hide();
            abrirMenu4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReglaDeSimpsonTresOctavos abrirMenu4 = new ReglaDeSimpsonTresOctavos();
            this.Hide();
            abrirMenu4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReglaDelTrapecioPorIntervalos abrirMenu4 = new ReglaDelTrapecioPorIntervalos();
            this.Hide();
            abrirMenu4.Show();
        }
        private void Integracion_Load(object sender, EventArgs e)
        {

        }

        private void excelInt_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Integración.xlsx";
            abrir.Start();
        }
    }
}
