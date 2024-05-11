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
    public partial class Secante : Form
    {
        public Secante()
        {
            InitializeComponent();
        }
        private void resolver_Click(object sender, EventArgs e)
        {
            //Declaro el objeto de la libreria
            Calculo FormulaDada = new Calculo();
            
            //Declaro las vaiables principales
            string EcuacionDada = textboxFx.Text;
            double p, Fxi = 0, Fxi1 = 0, PorcentajeActual, Valor = 0, Valores = 0;
            
            //Variable para el contador, esta igualada a cero porque debe de comenzar en la iteracion 0
            int i = 0;

            // Convertí los texbox en doubles
            double Xi = Convert.ToDouble(textboxXi.Text); 
            double Xi1 = Convert.ToDouble(textboxXimenos1.Text);
            double ErrorEsperado = Convert.ToDouble(textboxEs.Text);
            p = Convert.ToDouble(textboxP.Text);

            //Este bucle me permitira correr el programa hasta que este mismo cambie el valor actual el
            //cual es true por un false, debido a el break agregado al final de este
            while (true)
            {
                //Creamos la tabla y le asigno sus valores correspondientes
                int z = DataGridViewSecante.Rows.Add();
                DataGridViewSecante.Rows[z].Cells[0].Value = i++;
                DataGridViewSecante.Rows[z].Cells[1].Value = Xi1;
                DataGridViewSecante.Rows[z].Cells[2].Value = Xi;
                
                Valor = Xi1;// cree una variable Valor que tendra los valores de Xi1, luego se utilizara para calcular el porcentaje
                
                FormulaDada.Sintaxis(EcuacionDada, 'x'); //sintaxis de la ecuacion, me permitira remplazar lo que tenga el valor de "x" en la ecuacion ingresada
                Fxi = FormulaDada.EvaluaFx(Xi); //EL valor de Fxi sera el que nos de la ecuacion ya realizada con el valor de Xi
                Fxi1 = FormulaDada.EvaluaFx(Xi1); //EL valor de Fxi1 sera el que nos de la ecuacion ya realizada con el valor de Xi1
                DataGridViewSecante.Rows[z].Cells[3].Value = Fxi1;
                DataGridViewSecante.Rows[z].Cells[4].Value = Fxi;
                DataGridViewSecante.Rows[z].Cells[5].Value = Math.Abs(((p - Xi) / p) * 100); //Calcula el valor de ERP
                PorcentajeActual = Math.Abs((Xi - Valor) / Xi) * 100; //Calcula el valor de Ea
                DataGridViewSecante.Rows[z].Cells[6].Value = PorcentajeActual; //lo muestro en el dtgv
                
                Valores = Xi;// Guardo en Valores los datos de Xi para no perder el valor anterior
                //Si el valor de PorcenjeActual es menor o igual de ErrorEsperado se terminara el programa y tendremos
                //nuestra respuesta, como indica el algoritmo
                if (PorcentajeActual <= ErrorEsperado)
                {
                    break;//Si Ea es menor o igual a es terminara el programa si no
                }
                else
                {
                    Xi = Xi - ((Fxi * (Valor - Xi)) / (Fxi1 - Fxi)); //Calculamos el nuevo valor de Xi para el siguiente ciclo
                    Xi1 = Valores; //Y cambiamos el valor de Xi1 con lo que teniamos guardado de Valores
                }



            }
        }


        private void retroceder1_Click(object sender, EventArgs e)
        {
            Menu SecanteAtras = new Menu();
            this.Hide();
            SecanteAtras.Show();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            textboxFx.Text = " ";
            textboxEs.Text = " ";
            textboxP.Text = " ";
            textboxXimenos1.Text = " ";
            textboxXi.Text = " ";
            DataGridViewSecante.Rows.Clear();
        }

        private void Secante_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
