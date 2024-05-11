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
    public partial class ReglaDeSimpsonUnTercio : Form
    {
        public ReglaDeSimpsonUnTercio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Utilizo y creo EcuacionUtilizada gracias a la libreria calculus
            Calculo EcuacionUtilizada = new Calculo();
            
            //inserto los datos dados en las variables
            string Ec = txbEcuacion.Text;
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double P = Convert.ToDouble(txbP.Text);
            
            //Declaro las variable sque utilizare
            double fa, fb, Erp, Inte, f1, h, x1;
            
            //Calculamos el valor de h con la siguiete formula
            h = (b - a) / 2;
            x1 = a + h;
            
            //Se encarga de calcular el valor de f(a) y f(b)
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            fa = EcuacionUtilizada.EvaluaFx(a);
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            fb = EcuacionUtilizada.EvaluaFx(b);
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            f1 = EcuacionUtilizada.EvaluaFx(x1);
            
            //Calculamos el valor de la integral del trapecio
            Inte = (b - a) * ((fa + (4 * f1) + fb) / 6);
            Erp = Math.Abs(((P - Inte) / P) * 100);
            
            //se redondea
            Inte = Math.Round(Inte, 4);
            Erp = Math.Round(Erp, 2);
            fa = Math.Round(fa, 4);
            fb = Math.Round(fb, 4);
            f1 = Math.Round(f1, 4);
            
            //Mandamos a imprimir en los labels
            lblERPI.Text = Convert.ToString(Erp);
            lblfa.Text = Convert.ToString(fa);
            lblfb.Text = Convert.ToString(fb);
            lblfx1.Text = Convert.ToString(f1);
            lblI.Text = Convert.ToString(Inte);
        }

        //borra todos los datos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblfx1.Text = "-";
            lblfa.Text = "-";
            lblfb.Text = "-";
            lblI.Text = "-";
            lblERPI.Text = "-";
            txbA.Text = "";
            txbB.Text = "";
            txbEcuacion.Text = "";
            txbP.Text = "";
        }

        //Regresa al form anterior
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Integracion retrocede = new Integracion();
            retrocede.Show();
        }

        private void ReglaDeSimpsonUnTercio_Load(object sender, EventArgs e)
        {

        }
    }
}
