using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace RaulProyect
{
    public partial class metodoJacobi : Form
    {
        public metodoJacobi()
        {
            InitializeComponent();
        }

        // Perimite guardar las ecuaciones
        private void botonInsertar_Click(object sender, EventArgs e)
        {
            ecuaciones[contador] = tbEcNueva.Text;
            contador++;
            dgvEcuacionesGuardadas.Rows.Add("X" + contador + "= " + tbEcNueva.Text);
        }
        //Mando a llamar a apolloJacobi
        private void botonCalcular_Click(object sender, EventArgs e)
        {
            Form calculos = new ApolloJacobi(contador, ecuaciones, es);
            calculos.Show();
            this.Hide();
        }
        //Es un evento del bonton que convierte el error esperado 
        private void botonEs_Click(object sender, EventArgs e)
        {
            string aux = tbEs.Text;//.Replace("0.", "1");
            aux = aux.Replace(".", ",");
            es = Convert.ToDouble(aux);
            //es %= 1;
        }
        //Declaro variables para utilizarlas despues
        public int contador = 0;
        public string[] ecuaciones = new string[5];
        public double es;
        private void metodoJacobi_Load(object sender, EventArgs e)
        {

        }
    }
}
