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
    public partial class Newton : Form
    {
        public Newton()
        {
            InitializeComponent();
        }
        private void resolver_Click(object sender, EventArgs e)
        {
            //Creo el objeto de la libreria calculus
            Calculo Calculador = new Calculo();
            
            //Creo las variables generales
            string Fdex = textboxFx.Text;
            string DerivadaDeFdex = textboxDFx.Text;
            double P, Fx = 0, EcuacionFx = 0, Datos = 0;
            
            // Convertimos los texbox a doubles
            double Xi = Convert.ToDouble(textboxX.Text);
            double ErrorEsperado = Convert.ToDouble(textboxEs.Text);
            P = Convert.ToDouble(textboxP.Text);
            
            //Variables para el contador
            int i = 0;
            int cont = 0;

            DataGridViewGuapo.Rows.Add(); //Creamos la tabla y con esto llenamos la primera fila
            
            DataGridViewGuapo.Rows[cont].Cells[0].Value = i++;//Asignamos el valor "0" en la posicion [0], siendo esta la primera iteracion
            DataGridViewGuapo.Rows[cont].Cells[1].Value = Xi;//Agrego Xi a el dtgv
            DataGridViewGuapo.Rows[cont].Cells[2].Value = "-";//La  primera fila siempre es null, por eso le pongo "-"
            DataGridViewGuapo.Rows[cont].Cells[3].Value = "-";//La  primera fila siempre es null, por eso le pongo "-"
            cont = cont + 1;//Contador de las filas
            
            //Algoritmo
            //Este bucle me permitira correr el programa hasta que este mismo cambie el valor actual
            //el cual es true por un false, debido a el break agregado al final de este
            while (true)
            {
                Calculador.Sintaxis(Fdex, 'x'); //Mando el valor de la ecuacion y además le dije que remplazara lo que tenga el valor de "x" 
                Fx = Calculador.EvaluaFx(Xi); // Guardo el valor de Fx de la sustitución de Xi en la ecuación
                Calculador.Sintaxis(DerivadaDeFdex, 'x');//Seria lo mismo pero en vez de "Fdex" sea la DerivadaDeFdex
                EcuacionFx = Calculador.EvaluaFx(Xi);// Guardo el resultado de la sustitucion en EcuacionesFx
                Xi = Xi - (Fx / EcuacionFx);//Aquí calculo el valor de la nueva Xi
                
                DataGridViewGuapo.Rows.Add();
                DataGridViewGuapo.Rows[cont].Cells[0].Value = i++;//Aumenta el ciclo 1 a 1
                DataGridViewGuapo.Rows[cont].Cells[1].Value = Xi;
                DataGridViewGuapo.Rows[cont].Cells[2].Value = Math.Abs(((P - Xi) / P) * 100); //Calcula el valor de ERP
                DataGridViewGuapo.Rows[cont].Cells[3].Value = Math.Abs((Xi - Datos) / Xi) * 100;//Calcula el valor de Ea

                //Comparara el valor que tenemos de Ea con el vaor de es 
                if (Convert.ToDouble(DataGridViewGuapo.Rows[cont].Cells[3].Value.ToString()) <= ErrorEsperado) 
                {
                    break; //Si Ea es menor o igual a es terminara el programa si no
                }
                cont = cont + 1;//aumentara el contador 1 a 1
                Datos = Xi;// y asignara el valor de Xi a Datos
            }

        }
        private void retroceder1_Click(object sender, EventArgs e)
        {
            Menu NewtonAtras = new Menu();
            this.Hide();
            NewtonAtras.Show();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            textboxFx.Text = " ";
            textboxEs.Text = " ";
            textboxP.Text = " ";
            textboxX.Text = " ";
            textboxDFx.Text = " ";
            DataGridViewGuapo.Rows.Clear();
        }

        private void Newton_Load(object sender, EventArgs e)
        {

        }


    }
}
