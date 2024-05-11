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
    public partial class ReglaDelTrapecioPorIntervalos : Form
    {
        public ReglaDelTrapecioPorIntervalos()
        {
            InitializeComponent();
        }

        private void ReglaDelTrapecioPorIntervalos_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaro bariables que utilizare 
            double fa, fb, Erp, Inte, f1, f2, f3, f4, f5;
            double x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, h;
            
            //Creo EcuacionUtilizada para utilizar la libreria calculus
            Calculo EcuacionUtilizada = new Calculo();
            
            //Inseto datos en variables
            string Ec = txbEcuacion.Text;
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double P = Convert.ToDouble(txbP.Text);
            double n = Convert.ToDouble(txbH.Text);
   
            h = (b - a) / n;
            //Calculamos el valor de f(a) y f(b) 
            if (n == 2)
            {
                x1 = a + h;
            }
            else if (n == 3)
            {
                x1 = a + h;
                x2 = x1 + h;
            }
            else if (n == 4)
            {
                x1 = a + h;
                x2 = x1 + h;
                x3 = x2 + h;
            }
            else if (n == 5)
            {
                x1 = a + h;
                x2 = x1 + h;
                x3 = x2 + h;
                x4 = x3 + h;
            }
            else if (n == 6)
            {
                x1 = a + h;
                x2 = x1 + h;
                x3 = x2 + h;
                x4 = x3 + h;
                x5 = x4 + h;
            }
            
            //Se sustituyen los valores de a,b,x1,x2......xn en la ecuacion dada
            EcuacionUtilizada.Sintaxis(Ec, 'x');
            fa = EcuacionUtilizada.EvaluaFx(a);
            fb = EcuacionUtilizada.EvaluaFx(b);
            f1 = EcuacionUtilizada.EvaluaFx(x1);
            f2 = EcuacionUtilizada.EvaluaFx(x2);
            f3 = EcuacionUtilizada.EvaluaFx(x3);
            f4 = EcuacionUtilizada.EvaluaFx(x4);
            f5 = EcuacionUtilizada.EvaluaFx(x5);
            
            //Se encarga de los valores que sean null se toman como 0
            if (n == 2)
            {
                f2 = 0;
                f3 = 0;
                f4 = 0;
                f5 = 0;
            }
            else if (n == 3)
            {
                f3 = 0;
                f4 = 0;
                f5 = 0;
            }
            else if (n == 4)
            {
                f4 = 0;
                f5 = 0;
            }
            else if (n == 5)
            {
                f5 = 0;
            }
            
            //Aqui es donde Calculo el valor de la integral del trapecio
            Inte = (fa + 2 * (f1 + f2 + f3 + f4 + f5) + fb) * (h / 2);
            Erp = Math.Abs(((P - Inte) / P) * 100);
            
            //Redondeo a 4 decimales, no es obligatorio, pero a mi me gusta
            Inte = Math.Round(Inte, 4);
            Erp = Math.Round(Erp, 2);
            fa = Math.Round(fa, 4);
            fb = Math.Round(fb, 4);
            f1 = Math.Round(f1, 4);
            f2 = Math.Round(f2, 4);
            f3 = Math.Round(f3, 4);
            f4 = Math.Round(f4, 4);
            f5 = Math.Round(f5, 4);
            
            //imprimo resultados en los labels
            lblERPI.Text = Convert.ToString(Erp);
            lblfa.Text = Convert.ToString(fa);
            lblfb.Text = Convert.ToString(fb);
            lblI.Text = Convert.ToString(Inte);
            lblfx1.Text = Convert.ToString(f1);
            lblfx2.Text = Convert.ToString(f2);
            lblfx3.Text = Convert.ToString(f3);
            lblfx4.Text = Convert.ToString(f4);
            lblfx5.Text = Convert.ToString(f5);
        }

        //Limpios todo lo que escribimos y resultados
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblfx1.Text = "-";
            lblfx2.Text = "-";
            lblfx3.Text = "-";
            lblfx4.Text = "-";
            lblfx5.Text = "-";
            lblfa.Text = "-";
            lblfb.Text = "-";
            lblI.Text = "-";
            lblERPI.Text = "-";
            txbA.Text = "";
            txbB.Text = "";
            txbEcuacion.Text = "";
            txbH.Text = "";
            txbP.Text = "";
        }

        //Retrocede una vez
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Integracion retrocede = new Integracion();
            retrocede.Show();
        }
    }
}
