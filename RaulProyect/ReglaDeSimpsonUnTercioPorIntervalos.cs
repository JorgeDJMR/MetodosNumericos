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
    public partial class ReglaDeSimpsonUnTercioPorIntervalos : Form
    {
        public ReglaDeSimpsonUnTercioPorIntervalos()
        {
            InitializeComponent();
        }

        private void Calculador_Click(object sender, EventArgs e)
        {
            //Declaro las variables que utilizare
            double fa, fb, Erp, Inte, f1, f2, f3, f4, f5, f6;
            double x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, h;
            
            //Creo EcuacionUtilizada para poder utilizar la libreria calculus
            Calculo EcuacionUtilizada = new Calculo();
            
            //Inserto los datos ofrecidos en las variables que declare anteriormente
            string Ec = txbEcuacion.Text;
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double P = Convert.ToDouble(txbP.Text);
            double n = Convert.ToDouble(txbH.Text);

            //h se calcula
            h = (b - a) / n;
            
            //Calculamos el valor de f(a) y f(b), como anteriormente
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
            else if (n == 7)
            {
                x1 = a + h;
                x2 = x1 + h;
                x3 = x2 + h;
                x4 = x3 + h;
                x5 = x4 + h;
                x6 = x5 + h;
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
            f6 = EcuacionUtilizada.EvaluaFx(x6);
            if (n == 2)
            {
                f2 = 0;
                f3 = 0;
                f4 = 0;
                f5 = 0;
                f6 = 0;
            }
            else if (n == 3)
            {
                f3 = 0;
                f4 = 0;
                f5 = 0;
                f6 = 0;
            }
            else if (n == 4)
            {
                f4 = 0;
                f5 = 0;
                f6 = 0;
            }
            else if (n == 5)
            {
                f5 = 0;
                f6 = 0;
            }
            else if (n == 6)
            {
                f6 = 0;
            }
            //resuelve y calcula el valor de la integral del trapecio
            Inte = (b - a) * ((fa + 4 * (f1 + f3 + f5) + 2 * (f2 + f4 + f6) + fb) / (3 * n));
            Erp = Math.Abs(((P - Inte) / P) * 100);
           
            //Redondeo a 4 decimales
            Inte = Math.Round(Inte, 4);
            Erp = Math.Round(Erp, 2);
            fa = Math.Round(fa, 4);
            fb = Math.Round(fb, 4);
            f1 = Math.Round(f1, 4);
            f2 = Math.Round(f2, 4);
            f3 = Math.Round(f3, 4);
            f4 = Math.Round(f4, 4);
            f5 = Math.Round(f5, 4);
            f6 = Math.Round(f6, 4);
            
            //imprime los resultados en los labels
            lblERPI.Text = Convert.ToString(Erp);
            lblfa.Text = Convert.ToString(fa);
            lblfb.Text = Convert.ToString(fb);
            lblI.Text = Convert.ToString(Inte);
            lblfx1.Text = Convert.ToString(f1);
            lblfx2.Text = Convert.ToString(f2);
            lblfx3.Text = Convert.ToString(f3);
            lblfx4.Text = Convert.ToString(f4);
            lblfx5.Text = Convert.ToString(f5);
            lblfx6.Text = Convert.ToString(f6);
        }

        //Borra todos los datos en el forms
        private void borrador_Click(object sender, EventArgs e)
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
            lblfx6.Text = "-";
        }

        //retrocede al form anterior
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Integracion retrocede = new Integracion();
            retrocede.Show();
        }

        private void ReglaDeSimpsonUnTercioPorIntervalos_Load(object sender, EventArgs e)
        {

        }
    }
}
