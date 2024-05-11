using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaulProyect
{
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
        }
        private void Unidad2_Click(object sender, EventArgs e)
        {
            Menu abrirMenu = new Menu();
            this.Hide();
            abrirMenu.Show();
        }

        private void Unidad3_Click(object sender, EventArgs e)
        {
            MenuUnidad3 abrirMenu3 = new MenuUnidad3();
            this.Hide();
            abrirMenu3.Show();
        }

        private void Unidad4_Click(object sender, EventArgs e)
        {
            MenuUnidad4 abrirMenu4 = new MenuUnidad4();
            this.Hide();
            abrirMenu4.Show();
        }
        private void Unidad1_Click(object sender, EventArgs e)
        {
            TabajosUnidad1 abrirMenu3 = new TabajosUnidad1();
            this.Hide();
            abrirMenu3.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void MenuGeneral_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
