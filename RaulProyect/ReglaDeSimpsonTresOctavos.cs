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
    public partial class ReglaDeSimpsonTresOctavos : Form
    {
        public ReglaDeSimpsonTresOctavos()
        {
            InitializeComponent();
        }

        private void ResolverElProblema_Click(object sender, EventArgs e)
        {
            //Creo EcuacionUtilizada para poder utilizar la libreria mas adelante
            Calculo EcuacionUtilizada = new Calculo();
            
            //Inseto datos
            string Ec = txbEcuacion.Text;
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double P = Convert.ToDouble(txbP.Text);
            double fa, fb, Erp, Inte, f1, h, x1, x2, f2;
            h = (b - a) / 3;
            x1 = a + h;
            x2 = x1 + h;
            
            //Calculamos el valor de f(a) y f(b)
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            fa = EcuacionUtilizada.EvaluaFx(a);
            fb = EcuacionUtilizada.EvaluaFx(b);
            f1 = EcuacionUtilizada.EvaluaFx(x1);
            f2 = EcuacionUtilizada.EvaluaFx(x2);
            
            //Simplemente calculo el valor de la integral del trapecio
            Inte = (b - a) * ((fa + (3 * f1) + (3 * f2) + fb) / 8);
            Erp = Math.Abs(((P - Inte) / P) * 100);
            
            //Redondeo a 4 decimales
            Inte = Math.Round(Inte, 4);
            Erp = Math.Round(Erp, 2);
            fa = Math.Round(fa, 4);
            fb = Math.Round(fb, 4);
            f1 = Math.Round(f1, 4);
            f2 = Math.Round(f2, 4);
            
            //imprimo resultados
            lblERPI.Text = Convert.ToString(Erp);
            lblfa.Text = Convert.ToString(fa);
            lblfb.Text = Convert.ToString(fb);
            lblfx1.Text = Convert.ToString(f1);
            lblI.Text = Convert.ToString(Inte);
            lblfx2.Text = Convert.ToString(f2);
        }

        //Se encarga de borrar todos los datos escritos y mostrados
        private void BorraTodo_Click(object sender, EventArgs e)
        {
            lblfx1.Text = "-";
            lblfx2.Text = "-";
            lblfa.Text = "-";
            lblfb.Text = "-";
            lblI.Text = "-";
            lblERPI.Text = "-";
            txbA.Text = "";
            txbB.Text = "";
            txbEcuacion.Text = "";
            txbP.Text = "";
        }

        //Retrocede una vez
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Integracion retrocede = new Integracion();
            retrocede.Show();
        }

        private void ReglaDeSimpsonTresOctavos_Load(object sender, EventArgs e)
        {

        }
    }
    
}
