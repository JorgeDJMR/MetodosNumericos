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
    public partial class MenuUnidad3 : Form
    {
        public MenuUnidad3()
        {
            InitializeComponent();
        }

        private void okokookok_Click(object sender, EventArgs e)
        {

        }

        private void Gauss_Click(object sender, EventArgs e)
        {
            gauss abrirGauss = new gauss();
            this.Hide();
            abrirGauss.Show();
        }

        private void Jacobi_Click(object sender, EventArgs e)
        {
            metodoJacobi abrirJacobi = new metodoJacobi();
            this.Hide();
            abrirJacobi.Show();
        }

        private void GaussSeidel_Click(object sender, EventArgs e)
        {
            gaussseidel abrirGaussSeidel = new gaussseidel();
            this.Hide();
            abrirGaussSeidel.Show();
        }

        private void IterativoSecuencial_Click(object sender, EventArgs e)
        {
            iterativosecuencial abrirIterativoSecuencial = new iterativosecuencial();
            this.Hide();
            abrirIterativoSecuencial.Show();
        }

        private void retroceder1_Click(object sender, EventArgs e)
        {
            MenuGeneral menuGeneralAtras = new MenuGeneral();
            this.Hide();
            menuGeneralAtras.Show();
        }

        private void ReporteAbrir_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"ReporteOficialUnidad3.pdf";
            abrir.Start();
        }

        private void EjerciciosAbrir_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"clase.xlsx";
            abrir.Start();
        }

        private void ExcelAbrir_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Firmas (1).pdf";
            abrir.Start();
        }

        private void Problemario1_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Problemario 1.xlsx";
            abrir.Start();
        }
    }
}
