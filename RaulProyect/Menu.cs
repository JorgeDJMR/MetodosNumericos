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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        
        }

        private void Biseccion_Click(object sender, EventArgs e)
        {
            Bisección abrirBiseccion = new Bisección();
            this.Hide();
            abrirBiseccion.Show();
        }

        private void FalsaPosicion_Click(object sender, EventArgs e)
        {
            FalsaPosicion abrirFalsaPosicion = new FalsaPosicion();
            this.Hide();
            abrirFalsaPosicion.Show();
        }

        private void simple_Click(object sender, EventArgs e)
        {
            Simple abrirSimple = new Simple();
            this.Hide();
            abrirSimple.Show();
        }

        private void NewtonRhapson_Click(object sender, EventArgs e)
        {
            Newton abrirNewton = new Newton();
            this.Hide();
            abrirNewton.Show();
        }

        private void Secante_Click(object sender, EventArgs e)
        {
            Secante abrirSecante = new Secante();
            this.Hide();
            abrirSecante.Show();
        }

        private void retroceder1_Click(object sender, EventArgs e)
        {
            MenuGeneral menuGeneralAtras = new MenuGeneral();
            this.Hide();
            menuGeneralAtras.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ExcelCompleto_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"ExcelCompleto.xlsx";
            abrir.Start();
        }

        private void Reportem_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Reporte1.pdf";
            abrir.Start();
        }

        private void Ejercicios_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"ApuntesYTarea (1).pdf";
            abrir.Start();
        }

        private void TareaMoment_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Tarea.xlsx";
            abrir.Start();
        }
    }
}
