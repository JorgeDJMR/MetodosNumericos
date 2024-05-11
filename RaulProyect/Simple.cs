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
    public partial class Simple : Form
    {
        public Simple()
        {
            InitializeComponent();
        }

        private void resolver_Click(object sender, EventArgs e)
        {
            //Declaramos las variables y creamos el objeto de la libreria calculus xd
            Calculo CalculadorDeFormulas = new Calculo();
            

            double p;
            double Valores = 0;
            
            
            string Ex = textboxFx.Text; //Convertimos el valor del texbox de la ecuacion a un string, sera necesario más adelante
            p = Convert.ToDouble(textboxP.Text); // Convertimos los texbox a doubles
            double ErrorEsperado = Convert.ToDouble(textboxEs.Text); // Convertimos los texbox a doubles
            double Xi = Convert.ToDouble(textboxX.Text); // Convertimos los texbox a doubles
            
            //Servira para mi contador
            int i = 0;
            int cont = 0;

            DataGridViewSimple.Rows.Add(); //Creamos la tabla y con esto llenamos la primera fila que tendra los valores de 0
            DataGridViewSimple.Rows[cont].Cells[0].Value = i++; //Aumenta 1 a 1
            DataGridViewSimple.Rows[cont].Cells[1].Value = Xi; //Se muesta el valor de Xi en el dtgv
            DataGridViewSimple.Rows[cont].Cells[2].Value = Math.Abs(((p - Xi) / p) * 100); //Calcula el primer ERP
            DataGridViewSimple.Rows[cont].Cells[3].Value = 100;//comienza con 100%

            //Este bucle me permitira correr el programa hasta que este mismo cambie el valor actual el cual es true por un false, debido a
            //el break agregado al final de este
            while (true)
            {
                CalculadorDeFormulas.Sintaxis(Ex, 'x'); // sintaxis de la ecuacion, me permitira remplazar lo que tenga el valor de "x"
                Xi = CalculadorDeFormulas.EvaluaFx(Xi); 
                int z = DataGridViewSimple.Rows.Add();
                DataGridViewSimple.Rows[z].Cells[0].Value = i++;//Se encarga de aumentar el contador de iteraciones
                DataGridViewSimple.Rows[z].Cells[1].Value = Xi;
                DataGridViewSimple.Rows[z].Cells[2].Value = Math.Abs(((p - Xi) / p) * 100); //Para calcular el valor de ERP
                DataGridViewSimple.Rows[z].Cells[3].Value = Math.Abs(((Xi - Valores) / Xi) * 100); //Para calcular el valor de Ea

                //Si el valor en la columna 3 actual es menor o igual a el ErrorEsperado, parara (break)
                if (Convert.ToDouble(DataGridViewSimple.Rows[z].Cells[3].Value.ToString()) <= ErrorEsperado)
                {
                    break; 
                }

                Valores = Xi; // y asignara el valor de Xi a Valores
            }
        }
        private void retroceder1_Click_1(object sender, EventArgs e)
        {
            Menu SimpleAtras = new Menu();
            this.Hide();
            SimpleAtras.Show();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            textboxFx.Text = " ";
            textboxEs.Text = " ";
            textboxP.Text = " ";
            textboxX.Text = " ";
            DataGridViewSimple.Rows.Clear();
        }

        private void Simple_Load(object sender, EventArgs e)
        {

        }


    }
}
