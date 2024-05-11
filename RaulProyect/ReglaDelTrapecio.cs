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
    public partial class ReglaDelTrapecio : Form
    {
        public ReglaDelTrapecio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Utilizo la libreria Calculos 
            Calculo EcuacionUtilizada = new Calculo();
            
            //Insertoi los valores dados en las variables
            string Ec = txbEcuacion.Text;
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double P = Convert.ToDouble(txbP.Text);
            double fa, fb, Erp, Inte;
            
            //Calculo el valor de f(a) y f(b)
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            fa = EcuacionUtilizada.EvaluaFx(a);
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            fb = EcuacionUtilizada.EvaluaFx(b);
            
            //Aqui es donde calculo la integral del trapecio
            Inte = (b - a) * ((fa + fb) / 2);
            Erp = Math.Abs(((P - Inte) / P) * 100);

            ////Lo que haho aqui es simplemente redondiar a 4 decimales
            Inte = Math.Round(Inte, 4);
            Erp = Math.Round(Erp, 2);
            fa = Math.Round(fa, 4);
            fb = Math.Round(fb, 4);

            ////Aqui es sonde imprimo los resultados en los labels
            lblERPI.Text = Convert.ToString(Erp);
            lblfa.Text = Convert.ToString(fa);
            lblfb.Text = Convert.ToString(fb);
            lblI.Text = Convert.ToString(Inte);
        }

        //Se encarga de limpiar los datos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            txbA.Text = "";
            txbB.Text = "";
            txbEcuacion.Text = "";
            txbP.Text = "";
            lblERPI.Text = "-";
            lblfa.Text = "-";
            lblfb.Text = "-";
            lblI.Text = "-";
        }

        //Se encarga de retroceder al form anterior
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Integracion RegresarAMenu = new Integracion();
            this.Hide();
            RegresarAMenu.Show();
        }

        



        //Axidentes, no sirven para nada
        private void lblERPI_Click(object sender, EventArgs e)
        {

        }

        private void ReglaDelTrapecio_Load(object sender, EventArgs e)
        {

        }
    }
}
