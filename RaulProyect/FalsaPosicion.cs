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
    public partial class FalsaPosicion : Form
    {
        public FalsaPosicion()
        {
            InitializeComponent();
        }

        private void resolver_Click(object sender, EventArgs e)
        {
            //Declaramo las variables principales
            Calculo Calculador = new Calculo();
            
            string exprecion = textboxFx.Text;
            double Xr;   
            double PrimerValor;
            double SegundoValorXu;
            double Valores;
            double Fxl;
            double Fxu;
            double Fxr, Mulltiplicación;
            double p, Porcentaje;
            double Datos = 0;
            
            // Convertimos los texbox a doubles
            double Xu = Convert.ToDouble(textboxXu.Text);
            double Xl = Convert.ToDouble(textboxXl.Text);
            double ErrorEsperado = Convert.ToDouble(textboxEs.Text);
            p = Convert.ToDouble(textboxP.Text);
            
            //Variables para el contador
            int cont = 0; 
            int i = 1;

            //Este bucle me permitira correr el programa hasta que este mismo cambie el valor actual el cual es true por un false, debido a el break agregado al final de este
            while (true)
            {
                //Creamos la tabla Y la rellenamos con los primeros valores
                DataGridViewFalsaPosicion.Rows.Add();
                DataGridViewFalsaPosicion.Rows[cont].Cells[0].Value = i++;
                DataGridViewFalsaPosicion.Rows[cont].Cells[1].Value = Xl;
                DataGridViewFalsaPosicion.Rows[cont].Cells[2].Value = Xu;

                //Guardo los valores para luego utilizarlos en la ecuación
                PrimerValor = Xl;
                SegundoValorXu = Xu;

                Calculador.Sintaxis(exprecion, 'x');//Sintaxis de la ecuación, me permitira remplazar lo que tenga el valor de "x"

                Fxl = Calculador.EvaluaFx(PrimerValor);//Guardamos el valor de Fxl con lo que dio la ecuacion con la sustitucion de PrimerValor
                Fxu = Calculador.EvaluaFx(SegundoValorXu);//Guardamos el valor de Fxl con lo que dio la ecuacion con la sustitucion de SegundoValor
                Xr = Xu - ((Fxu * (Xl - Xu)) / (Fxl - Fxu));//Calculamos Xr
                Valores = Xr;//Guardamos el valor de Xr en Valores para no perder los valores anteriores
                DataGridViewFalsaPosicion.Rows[cont].Cells[3].Value = Xr;
                Fxr = Calculador.EvaluaFx(Valores);// Guardamos el valor de Fxr 

                //Imprimirmos los calculos que ralizamos con las ecuaciones
                DataGridViewFalsaPosicion.Rows[cont].Cells[4].Value = Fxl;
                DataGridViewFalsaPosicion.Rows[cont].Cells[5].Value = Fxu;
                DataGridViewFalsaPosicion.Rows[cont].Cells[6].Value = Fxr;
                
                Mulltiplicación = Fxl * Fxr; //Aquí Multiplico los valores de fxl*fxr y los guardo en Multiplicacion
           
                
                DataGridViewFalsaPosicion.Rows[cont].Cells[8].Value = Math.Abs(((p - Xr) / p) * 100); //Calculamos el valor de ERP
                Porcentaje = Math.Abs((Xr - Datos) / Xr) * 100;
                DataGridViewFalsaPosicion.Rows[cont].Cells[9].Value = Porcentaje;//Calculamos el valor de Ea


                //Algoritmo
                //Con la ayuda de la condicional "if", voy a poder conseguir asignar el signo correcto dependiendo del resultado
                // Si el valor de Multiplicacion es mayor a 0 entonces se imprimira  en el dgvt "+" y además cambiara el valor de Xl por el de Xr como lo dice el algoritmo
                if (Mulltiplicación > 0) 
                {
                    DataGridViewFalsaPosicion.Rows[cont].Cells[7].Value = "+";
                    Xl = Xr;
                }
                else// Si el valor de Multiplicacion es menor a 0 entonces se imprimira en el dgvt "-" y además cambiara el valor de Xu por el de Xr como lo dice el algoritmo
                {
                    DataGridViewFalsaPosicion.Rows[cont].Cells[7].Value = "-";
                    Xu = Xr;
                }
                Datos = Xr;//Guarda el valor de Xr en un Datos para guardar los valores anteriores de xr
                //Si el valor de Porcenje es menor o igual de ErrorEsperado se terminara el programa y tendremos nuestra respuesta, como indica el algoritmo
                if (Porcentaje <= ErrorEsperado)
                {
                    break;
                }
                cont = cont + 1;//Aumenta el contador 1 a 1
            }
        }

        private void retroceder1_Click(object sender, EventArgs e)
        {
            Menu FalsaPosicionAtras = new Menu();
            this.Hide();
            FalsaPosicionAtras.Show();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            //Me permite borrar los datos que se ingresaron en la tabla en los textbox
            textboxFx.Text = " ";
            textboxEs.Text = " ";
            textboxP.Text = " ";
            textboxXl.Text = " ";
            textboxXu.Text = " ";
            DataGridViewFalsaPosicion.Rows.Clear();
        }


        private void FalsaPosicion_Load(object sender, EventArgs e)
        {

        }
    }
}
