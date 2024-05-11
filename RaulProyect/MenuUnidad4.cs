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
    public partial class MenuUnidad4 : Form
    {
        public MenuUnidad4()
        {
            InitializeComponent();
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diferenciación ob1 = new Diferenciación();
            ob1.Show();
        }

        private void btnIntNum_Click(object sender, EventArgs e)
        {
            this.Hide();
            Integracion ob2 = new Integracion();
            ob2.Show();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            MenuGeneral RegresarAMenu = new MenuGeneral();
            this.Hide();
            RegresarAMenu.Show();
        }

        private void MenuUnidad4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"ReporteU4.pdf";
            abrir.Start();
        }

        private void LlamarEjercicios_Click(object sender, EventArgs e)
        {
            Process abrir = new Process();
            abrir.StartInfo.FileName = @"EjerciocioDerivacionEIntegracion-combinado.pdf";
            abrir.Start();
        }
    }
}
