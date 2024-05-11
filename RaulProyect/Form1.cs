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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resolver_Click(object sender, EventArgs e)
        {
            //Declaramos las variables y creamos el objeto de la libreria calculus xd
            Calculo formula = new Calculo();
            string exprecion = textboxFx.Text;
            double Xr, Xu = Convert.ToDouble(textboxXu.Text), Xl = Convert.ToDouble(textboxXl.Text); // Convertimos los texbox a doubles
            double cl;
            double cu;
            double cr;
            double fxl;
            double fxu;
            double fxr, fxg;
            double p, re;
            double aux = 0;
            double es = Convert.ToDouble(textboxEs.Text);// Convertimos los texbox a doubles
            p = Convert.ToDouble(textboxP.Text);// Convertimos los texbox a doubles
            int cont = 0; //Creamos el contador para repetir las filas hasta que se acabe
            int i = 0;

            while (true) //El programa correra hasta que cambie el valor de true a false por un break del final
            {
                //Creamos la tabla Y la rellenamos con los primeros valores
                DataGridViewBiseccion.Rows.Add();
                DataGridViewBiseccion.Rows[cont].Cells[0].Value = i++;
                DataGridViewBiseccion.Rows[cont].Cells[1].Value = Xl;
                DataGridViewBiseccion.Rows[cont].Cells[2].Value = Xu;


                cl = Xl;//Guardamos el valor de Xl en cl para pasarselo a la ecuacion
                cu = Xu;//Guardamos el valor de Xu en cu para pasarselo a la ecuacion

                formula.Sintaxis(exprecion, 'x');//Declaremos la sintaxis que tendra la ecuacion 

                fxl = formula.EvaluaFx(cl);//Guardamos el valor de fxl con lo que dio la ecuacion con la sustitucion de cl
                fxu = formula.EvaluaFx(cu);//Guardamos el valor de fxl con lo que dio la ecuacion con la sustitucion de cu
                Xr = Xu - ((fxu * (Xl - Xu)) / (fxl - fxu));//Calculamos el nuevo valor que tendra xr
                cr = Xr;//y la guardaremos en una variable para no perder los valores anteriores
                DataGridViewBiseccion.Rows[cont].Cells[3].Value = Xr;
                fxr = formula.EvaluaFx(cr);// Guardamos el valor de fxl con lo que dio la ecuacion con la sustitucion de cr
                //Imprimirmos los calculos que ralizamos con las ecuaciones
                DataGridViewBiseccion.Rows[cont].Cells[4].Value = fxl;
                DataGridViewBiseccion.Rows[cont].Cells[5].Value = fxu;
                DataGridViewBiseccion.Rows[cont].Cells[6].Value = fxr;
                fxg = fxl * fxr; //Multiplicamos los valores de fxl*fxr
                DataGridViewBiseccion.Rows[cont].Cells[8].Value = Math.Abs(((p - Xr) / p) * 100); //Calculamos el valor de ERP
                re = Math.Abs((Xr - aux) / Xr) * 100;
                DataGridViewBiseccion.Rows[cont].Cells[9].Value = re;//Calculamos el valor de Ea
                if (fxg > 0) // Si el valor de fxg es mayor a 0 imprimira en el dataGridView un "+" y cambaira el valor de xl por el de xr
                {
                    DataGridViewBiseccion.Rows[cont].Cells[6].Value = "+";
                    Xl = Xr;
                }
                else// Si el valor de gg es menor a 0 imprimira en el dataGridView un "-" y cambaira el valor de xu por el de xr
                {
                    DataGridViewBiseccion.Rows[cont].Cells[6].Value = "-";
                    Xu = Xr;
                }
                aux = Xr;//Guardara el valor de xr en un aux para guardar los valores anteriores de xr
                if (re <= es)//Si el valor de Ea es menor o igual de es se terminara el progrma es para si el valor que calculamos es menor o igual a el que ingresamos ya tendremos las respuestas
                {
                    break;
                }
                cont = cont + 1;//Aumentara el contador de las filas
            }
        
        }
    }
}
