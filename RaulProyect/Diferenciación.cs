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
    public partial class Diferenciación : Form
    {
        public Diferenciación()
        {
            InitializeComponent();
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            this.Hide();
            HaciaAdelante Abrir = new HaciaAdelante();
            Abrir.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            MenuUnidad4 RegresarAMenu = new MenuUnidad4();
            this.Hide();
            RegresarAMenu.Show();
        }



        private void btnIntNum_Click(object sender, EventArgs e)
        {
            HaciaAtras RegresarAMenu = new HaciaAtras();
            this.Hide();
            RegresarAMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Central RegresarAMenu = new Central();
            this.Hide();
            RegresarAMenu.Show();
        }
        private void Diferenciación_Load(object sender, EventArgs e)
        {

        }

        private void excelDif_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"Diferenciación.xlsx";
            abrir.Start();

        }
    }
}
