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
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }

        private void ResolverProblema_Click(object sender, EventArgs e)
        {
            try
            {
                //Utilizo la libreria y me preparo para uzarla
                Calculo Calculador = new Calculo();

                //Declaro las variables que utilizare a lo largo del programa.
                double x, y, a, b, c, d, f, n, g, h, a1, d1, n1, j, p2, p3, p4;
                
                //Declaro la variable, sera muy util en el programa.
                string Formula;


                //inserto los valores dados en las variables
                a1 = Convert.ToDouble(txt1.Text);
                d1 = Convert.ToDouble(txt2.Text);
                n1 = Convert.ToDouble(textBox2.Text);
                p2 = Convert.ToDouble(textBox3.Text);
                p3 = Convert.ToDouble(textBox4.Text);
                p4 = Convert.ToDouble(textBox5.Text);
                Formula = textBox1.Text;
                a = a1;
                d = d1;
                n = n1;

                //calculo xi, xi+1 o x-1 y las demas.
                b = a + d;
                c = a + (2 * d);
                f = a + (3 * d);
                g = a - d;
                h = a - (2 * d);
                j = a - (3 * d);
                
                //Creo un ciclo el cual se encarga de realizar las operaciones 
                
                for (int i = 0; i < 8; i++)
                {
                    //lo que hago aqui son las subtituciones de los valores de xi, xi+1 o x-1 y otras mas dependiendo del metodo,
                    //para que se sustituyan en la ecuacion ofresuida la cual esta guradada en la variable formula
                    if (i == 0)
                    {
                        x = a;
                        Calculador.Sintaxis(Formula, 'x');
                        a = Calculador.EvaluaFx(x);

                    }
                    else if (i == 1)
                    {
                        x = b;
                        Calculador.Sintaxis(Formula, 'x');
                        b = Calculador.EvaluaFx(x);
                    }
                    else if (i == 2)
                    {
                        x = c;
                        Calculador.Sintaxis(Formula, 'x');
                        c = Calculador.EvaluaFx(x);
                    }
                    else if (i == 3)
                    {
                        x = d;
                        Calculador.Sintaxis(Formula, 'x');
                        d = Calculador.EvaluaFx(x);
                    }
                    else if (i == 4)
                    {
                        x = f;
                        Calculador.Sintaxis(Formula, 'x');
                        f = Calculador.EvaluaFx(x);
                    }
                    else if (i == 5)
                    {
                        x = g;
                        Calculador.Sintaxis(Formula, 'x');
                        g = Calculador.EvaluaFx(x);
                    }
                    else if (i == 6)
                    {
                        x = h;
                        Calculador.Sintaxis(Formula, 'x');
                        h = Calculador.EvaluaFx(x);
                    }
                    else if (i == 7)
                    {
                        x = j;
                        Calculador.Sintaxis(Formula, 'x');
                        j = Calculador.EvaluaFx(x);
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
                        d = d1;
                        x = (b - g) / (2 * d); dtgv.Rows[z].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //Calculo ERP
                        x = ((n - x) / n) * 100;
                        dtgv.Rows[z].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        //Inserto datos en variable 'd'
                        d = d1;
                        y = (-(c) + 8 * (b) - 8 * (g) + h) / (12 * d); dtgv.Rows[z].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo ERP
                        y = ((n - y) / n) * 100;
                        dtgv.Rows[z].Cells[1].Value = Math.Abs(y);
                    }
                }

                // Creo un ciclo el cual  se va a encargar de mandar a la derivada, por orden.
                for (int i = 0; i < 2; i++)
                {
                    int zi = dtgv2.Rows.Add();
                    //lo que hago aqui es crear las condicionales if y else
                    //la cuales se encargaran de hacer las operaciones de la segunda derivada
                    if (i == 0)
                    {
                        d = d1;
                        x = (b - 2 * (a) + g) / (12 * (d * d)); dtgv2.Rows[zi].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //Calculo error
                        x = ((p2 - x) / p2) * 100;
                        dtgv2.Rows[zi].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        d = d1;
                        y = (-(c) + 16 * (b) - 30 * (a) + 16 * (g) - h) / (12 * (d * d)); dtgv2.Rows[zi].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo ERP
                        y = ((p2 - y) / p2) * 100;
                        dtgv2.Rows[zi].Cells[1].Value = Math.Abs(y);
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    int z = dtgv3.Rows.Add();
                    //lo que hago aqui es crear las condicionales if y else
                    //la cuales se encargaran de hacer las operaciones de la tercera derivada
                    if (i == 0)
                    {
                        d = d1;
                        x = (c - 2 * (b) + 2 * (g) - h) / (2 * (d * d * d)); dtgv3.Rows[z].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        //Calculo ERP
                        x = ((p3 - x) / p3) * 100;
                        dtgv3.Rows[z].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        d = d1;
                        y = (-f + 8 * (c) - 13 * (b) + 13 * (g) - 8 * (h) + j) / (8 * (d * d * d)); dtgv3.Rows[z].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                        //Calculo ERP
                        y = ((p3 - y) / p3) * 100;
                        dtgv3.Rows[z].Cells[1].Value = Math.Abs(y);
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    int z = dtgv4.Rows.Add();
                    //lo que hago aqui es crear las condicionales if y else
                    //la cuales se encargaran de hacer las operaciones de la cuarta derivada y ultima
                    //llegue hasta la cuarta pero podria seguir avanzando asi.
                    
                    if (i == 0)
                    {
                        d = d1;
                        x = (c - (4 * b) + (6 * a) - (4 * g) + h) / (d * d * d * d); dtgv4.Rows[z].Cells[0].Value = x;
                        string s = Convert.ToString(x);
                        x = Convert.ToDouble(s);
                        x = ((p4 - x) / p4) * 100;
                        
                        //Calculo ERP
                        dtgv4.Rows[z].Cells[1].Value = Math.Abs(x);

                    }
                    else if (i == 1)
                    {
                        d = d1;
                        y = (-f + 12 * (c) - 39 * (b) + 56 * (a) - 39 * (g) + 12 * (h) - j) / (6 * (d * d * d * d)); dtgv4.Rows[z].Cells[0].Value = y;
                        string s = Convert.ToString(y);
                        y = Convert.ToDouble(s);
                       
                        //Calculo ERP
                        y = ((p4 - y) / p4) * 100;
                        dtgv4.Rows[z].Cells[1].Value = Math.Abs(y);
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Ponga todos los datos correctamente");
            }
        }

        //Como el nombre del metodo dice se encarga de borrar lo que se ingresa en 
        //la tablas o texboxes, tambien lo del dtgv.
        private void BorrarTodo_Click(object sender, EventArgs e)
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


        //Lo uso para moverme rapido al codigo
        private void Central_Load(object sender, EventArgs e)
        {

        }
    }
}
