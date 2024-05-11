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
    public partial class Bisección : Form
    {
        public Bisección()
        {
            InitializeComponent();
        }

        private void resolver_Click(object sender, EventArgs e)
        {
            Calculo Calculador = new Calculo(); //Creamos el objeto de la libreria calculus para poder utilizarla más adelante
            
            //Declaro las variables principales
            Double Xl, Xu, Xr, Porcentaje = 100, ErrorEsperado, P, Multiplicacion;  
            Double Fxl, Fxu, Fxr, ValorAn = 0;
            string EcuacionDada;//Esta sera la variable donde guardare la ecuacion
            EcuacionDada = textboxFx.Text; //Guardamos lo que tengamos en el texbox de ecuacion
            int i = 1;//Este sera mi contador(comenzara desde la iteración 1), me servira más adelante para aumentar 1 a 1
            
            // Aqui convierto los textbox en doubles, ya que los necesitare así más adelante
            Xl = Convert.ToDouble(textboxXl.Text); 
            Xu = Convert.ToDouble(textboxXu.Text); 
            ErrorEsperado = Convert.ToDouble(textboxEs.Text); 
            P = Convert.ToDouble(textboxP.Text);

            //Este bucle me permitira correr el programa hasta que este mismo cambie el valor actual el cual es true por un false, debido a el break agregado al final de este
            while (true) 
            {
                //Simplemente creo la tabla e ingreso los valores a sus celdas correspondientes
                int z = DataGridViewBiseccion.Rows.Add();
                DataGridViewBiseccion.Rows[z].Cells[0].Value = i++;
                DataGridViewBiseccion.Rows[z].Cells[1].Value = Xl;
                DataGridViewBiseccion.Rows[z].Cells[2].Value = Xu;
                
                //Calculo "Xr", también me servida en un futuro para usarlo en la ecuación
                Xr = (Xl + Xu) / 2;
                
                //Una vez tenemos "Xr" lo vamos a mostrar en el DTGV
                DataGridViewBiseccion.Rows[z].Cells[3].Value = Xr;
                
                //Utilizando la libreria "Calculus" se declara la sintaxis que tendra la ecuación, sintaxis de la ecuacion, me permitira remplazar lo que tenga el valor de "x"
                Calculador.Sintaxis(EcuacionDada, 'x'); 
                Fxl = Calculador.EvaluaFx(Xl); //Se sustitulle Xl en Calculador y el resultado de esta operacion se guarda en Fxl
                Fxr = Calculador.EvaluaFx(Xr); //Se sustitulle Xr en Calculador y el resultado de esta operacion se guarda en Fxr
                Fxu = Calculador.EvaluaFx(Xu); //Se sustitulle Xu en Calculador y el resultado de esta operacion se guarda en Fxu

                //Envio los datos conseguidos anteriormente y los coloco enn sus celdas correspondientes
                DataGridViewBiseccion.Rows[z].Cells[4].Value = Fxl;
                DataGridViewBiseccion.Rows[z].Cells[5].Value = Fxu;
                DataGridViewBiseccion.Rows[z].Cells[6].Value = Fxr;

                Multiplicacion = Fxl * Fxr;//Aqui es donde calculo el valor de f(xl)*f(xr)

                DataGridViewBiseccion.Rows[z].Cells[8].Value = Math.Abs(((P - Xr) / P) * 100); //Aquí Calculo ERP
                Porcentaje = Math.Abs((Xr - ValorAn) / Xr) * 100; //Aquí Calculo Ea
                DataGridViewBiseccion.Rows[z].Cells[9].Value = Porcentaje;//Envio los datos de "Porcentaje" al dtgv


                //Algoritmo
                //Con la ayuda de la condicional "if", voy a poder conseguir asignar el signo correcto dependiendo del resultado
                // Si el valor de Multiplicacion es mayor a 0 entonces se imprimira  en el dgvt "+" y además cambiara el valor de Xl por el de Xr como lo dice el algoritmo
                if (Multiplicacion > 0)
                {
                    DataGridViewBiseccion.Rows[z].Cells[7].Value = "+";
                    Xl = Xr;


                }
                // Si el valor de Multiplicacion es menor a 0 entonces se imprimira en el dgvt "-" y además cambiara el valor de Xu por el de Xr como lo dice el algoritmo
                else if (Multiplicacion < 0)
                {
                    DataGridViewBiseccion.Rows[z].Cells[7].Value = "-";
                    Xu = Xr;

                }
                //Aquí estoy guardado el valor de Xr en ValorAn, de esta manera guardare los valores anteriores a Xr
                ValorAn = Xr;
                //Si el valor de Porcenje es menor o igual de ErrorEsperado se terminara el programa y tendremos nuestra respuesta, como indica el algoritmo
                if (Porcentaje <= ErrorEsperado)
                {
                    break;
                }
            }

        }


        private void retroceder1_Click(object sender, EventArgs e)
        {
            Menu BiseccionAtras = new Menu();
            this.Hide();
            BiseccionAtras.Show();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            //Limpia los textbox y el dtgv
            textboxFx.Text = " ";
            textboxEs.Text = " ";
            textboxP.Text = " ";
            textboxXl.Text = " ";
            textboxXu.Text = " ";
            DataGridViewBiseccion.Rows.Clear();
        }

        private void Bisección_Load(object sender, EventArgs e)
        {

        }
    }
}
