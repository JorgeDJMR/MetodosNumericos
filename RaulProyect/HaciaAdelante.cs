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
    public partial class HaciaAdelante : Form
    {
        public HaciaAdelante()
        {
            InitializeComponent();
        }

        private void ResolverProblema_Click(object sender, EventArgs e)
        {
            try
            {
                // Utilizo la libreria calculus
                Calculo Calculador = new Calculo();
                
                //Declaro todas las variables que utilizare a lo largo del programa, sera muy importante para los calculos
                //mas adelante
                string formula;
                
                //Declaro puros doubles para evitar problemas y para que sea mas facil y bonito
                double x, y, a, b, c, d, f, n, g, h, a1, d1, n1, p2, p3, p4;
                
                //inserto los valores dados en las variables
                a1 = Convert.ToDouble(txt1.Text);
                d1 = Convert.ToDouble(txt2.Text);
                n1 = Convert.ToDouble(textBox2.Text);
                p2 = Convert.ToDouble(textBox3.Text);
                p3 = Convert.ToDouble(textBox4.Text);
                p4 = Convert.ToDouble(textBox5.Text);
                formula = textBox1.Text;
                a = a1;
                d = d1;
                n = n1;
                
                //calculo xi, xi+1 o x-1 
                b = a + d;
                c = a + (2 * d);
                f = a + (3 * d);
                g = a + (4 * d);
                h = a + (5 * d);
                
                //Creo un ciclo el cual se encarga de realizar las operaciones 
                for (int i = 0; i < 7; i++)
                {
                    
                    if (i == 0)
                    {
                        //lo que hago aqui son las subtituciones de los valores de xi, xi+1 o x-1 y otras mas dependiendo del metodo,
                        //para que se sustituyan en la ecuacion ofresuida la cual esta guradada en la variable formula
                        x = a;
                        Calculador.Sintaxis(formula, 'x');
                        a = Calculador.EvaluaFx(x);

                    }
                    else if (i == 1)
                    {
                        x = b;
                        Calculador.Sintaxis(formula, 'x');
                        b = Calculador.EvaluaFx(x);
                    }
                    else if (i == 2)
                    {
                        x = c;
                        Calculador.Sintaxis(formula, 'x');
                        c = Calculador.EvaluaFx(x);
                    }
                    else if (i == 3)
                    {
                        x = d;
                        Calculador.Sintaxis(formula, 'x');
                        d = Calculador.EvaluaFx(x);
                    }
                    else if (i == 4)
                    {
                        x = f;
                        Calculador.Sintaxis(formula, 'x');
                        f = Calculador.EvaluaFx(x);
                    }
                    else if (i == 5)
                    {
                        
                        x = g;
                        Calculador.Sintaxis(formula, 'x');
                        g = Calculador.EvaluaFx(x);
                    }
                    else if (i == 6)
                    {
                        x = h;
                        Calculador.Sintaxis(formula, 'x');
                        h = Calculador.EvaluaFx(x);
                    }
                }
                
                // Creo un ciclo el cual  se va a encargar de mandar a la derivada, por orden.
                for (int i = 0; i < 2; i++)
                {
                    int z = dtgv.Rows.Add();
                    //lo que hago aqui es crear las condicionales  if y else
                    //la cuales se encargaran de hacer las operaciones de la primera derivada
                    if (i == 0)
                    {
                        //inserto valor en variable
                        d = d1;
                        x = (b - a) / d; dtgv.Rows[z].Cells[0].Value = x;
                        //convierto
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //Calculo el error
                        x = ((n - x) / n) * 100;
                        dtgv.Rows[z].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        //Mas de lo mismo
                        d = d1;
                        y = (-(c) + 4 * (b) - 3 * (a)) / (2 * d); dtgv.Rows[z].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo el error
                        y = ((n - y) / n) * 100;
                        dtgv.Rows[z].Cells[1].Value = Math.Abs(y);
                    }
                }

                //  Creo un ciclo el cual  se va a encargar de mandar a la derivada, por orden.
                for (int i = 0; i < 2; i++)
                {

                    int zi = dtgv2.Rows.Add();
                    //lo que hago aqui es crear las condicionales if y else
                    //la cuales se encargaran de hacer las operaciones de la segunda derivada
                    if (i == 0)
                    {
                        //inserto datos en varible d
                        d = d1;
                        x = (c - 2 * (b) + a) / (d * d); dtgv2.Rows[zi].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //Calculo el error
                        x = ((p2 - x) / p2) * 100;
                        dtgv2.Rows[zi].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        //inserto datos en varible d
                        d = d1;
                        y = (-(f) + 4 * (c) - 5 * (b) + 2 * (a)) / (d * d); dtgv2.Rows[zi].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo error
                        y = ((p2 - y) / p2) * 100;
                        dtgv2.Rows[zi].Cells[1].Value = Math.Abs(y);
                    }
                }

                //Hago lo mismo para calcular las derivadas, solo cambio un par de cosas.

                //  Creo un ciclo el cual  se va a encargar de mandar a la derivada, por orden.
                for (int i = 0; i < 2; i++)
                {
                    int z = dtgv3.Rows.Add();
                    //lo que hago aqui es crear las condicionales if y else
                    //la cuales se encargaran de hacer las operaciones de la tercera derivada
                    if (i == 0)
                    {
                        d = d1;
                        x = (f - 3 * (c) + 3 * (b) - a) / (d * d * d); dtgv3.Rows[z].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //calculo error
                        x = ((p3 - x) / p3) * 100;
                        dtgv3.Rows[z].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        //inserto datos
                        d = d1;
                        y = (-3 * (g) + 14 * (f) - 24 * (c) + 18 * (b) - 5 * (a)) / (2 * (d * d * d)); dtgv3.Rows[z].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo error
                        y = ((p3 - y) / p3) * 100;
                        dtgv3.Rows[z].Cells[1].Value = Math.Abs(y);
                    }
                }
                //Lo mismo que antes
                for (int i = 0; i < 2; i++)
                {
                    int z = dtgv4.Rows.Add();
                    //lo que hago aqui es crear las condicionales if y else
                    //la cuales se encargaran de hacer las operaciones de la cuarta derivada y ultima
                    //llegue hasta la cuarta pero podria seguir avanzando asi.
                    if (i == 0)
                    {
                        d = d1;
                        x = (g - 4 * (f) + 6 * (c) - 4 * (b) + a) / (d * d * d * d); dtgv4.Rows[z].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //Calculo error
                        x = ((p4 - x) / p4) * 100;
                        dtgv4.Rows[z].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        d = d1;
                        y = (-2 * (h) + 11 * (g) - 24 * (f) + 26 * (c) - 14 * (b) + 3 * (a)) / (d * d * d * d); dtgv4.Rows[z].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo error
                        y = ((p4 - y) / p4) * 100;
                        dtgv4.Rows[z].Cells[1].Value = Math.Abs(y);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ponga todos los datos correctamente");
            }
        }

        //Como el nombre del metodo dice se encarga de borrar lo que se ingresa en 
        //la tablas o texboxes, tambien lo del dtgv.
        private void BorraTodo_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            dtgv.Rows.Clear();
            dtgv2.Rows.Clear();
            dtgv3.Rows.Clear();
            dtgv4.Rows.Clear();
        }

        //Se encarga de retroceder una vez, para poder regresar a lo anterior.
        private void Retroceder_Click(object sender, EventArgs e)
        {
            Diferenciación RegresarAMenu = new Diferenciación();
            this.Hide();
            RegresarAMenu.Show();
        }


    }
}