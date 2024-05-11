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
    public partial class gauss : Form
    {
        public gauss()
        {
            InitializeComponent();
        }
        //Variables declaradas que utilizare más adelante
        Double x = 0;
        Double y = 0;
        private void resolver_Click(object sender, EventArgs e)
        {
            try
            {
                //Creo los ciclos que se encargaran de recorrer la matriz insertada en DTGV
                for (int i = 0; i < dtgv3.ColumnCount - 1; i++)
                {
                    for (int j = i; j < dtgv3.RowCount; j++)
                    {
                        //Creo la condicion  para que cuando i y j sean iguales se divida el numero de la 
                        //celda entre el numero superior de la diagonal
                        if (i == j)
                        {
                            //Se guarda el valor de la diagonal de la columna correspondiente
                            indicador = Convert.ToDouble(dtgv3[i, j].Value);
                            z = j;
                            //Este ciclo se encarga de realizar las operaciones a todos los renglones
                            for (int k = 0; k < dtgv3.ColumnCount; k++)
                            {
                                ////Realiza las operaciones a los renglones
                                dtgv3[k, j].Value = Convert.ToDouble(dtgv3[k, j].Value) / indicador;
                            }
                        }
                        else
                        {
                            //Aquí guardo el valor de la celda que sr quiere cambiar y luego le cambio de signo
                            Ayuda = Convert.ToDouble(dtgv3[i, j].Value) * -1;
                            //Este for se encarga de  la operacion para el cambio de la fila correspondiente
                            for (int k = 0; k < dtgv3.ColumnCount; k++)
                            {
                                dtgv3[k, j].Value = ((Convert.ToDouble(dtgv3[k, z].Value) * Ayuda) + Convert.ToDouble(dtgv3[k, j].Value));
                            }
                        }
                    }
                }
                // Aquí creo un ciclo para poder realizar la sustitucion de atras hacia delante
                for (int i = dtgv3.RowCount - 1; i >= 0; i--)
                {
                    ValorSuma = 0;
                    Cambiante = dtgv3.RowCount - 1;

                    for (int j = dtgv3.ColumnCount - 2; j >= i; j--)
                    {
                        //Basicamente si las dos variables de los ciclos son iguales,
                        //entoces se realizara la operación
                        if (i == j)
                        {
                            //Cambio el valor de la celda
                            dtgv3[dtgv3.ColumnCount - 1, i].Value = Convert.ToDouble(dtgv3[dtgv3.ColumnCount - 1, i].Value) - ValorSuma;
                        }
                        //De lo contrario realizara esta operacion
                        else
                        {
                            //Se guardan valores de las celdas
                            x = Convert.ToDouble(dtgv3[j, i].Value);
                            // Para luego utilizarlas en una operacion
                            y = Convert.ToDouble(dtgv3[dtgv3.ColumnCount - 1, Cambiante].Value);
                            //Hago un cambio en el valor de la variable
                            ValorSuma += x * y;
                            Cambiante--;
                        }
                    }
                    //Guardo los resultados de una variable
                    valorResultado += Environment.NewLine + "X" + (i + 1) + "= " + dtgv3[dtgv3.ColumnCount - 1, i].Value + "\n";

                }
                //Aquí guardo los resultados del text box
                textBoxResultados.Text = valorResultado;
            }
            catch (Exception ex)
            {
                String Error = ex.Message;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //Se guara en la variable el tamaño seleccionado del ComboBox en una variable
                int NumeroTamanio = int.Parse(box1.Text);
                //Aquí creo el tamaño de las filas y columnas que estaran en el DTGV
                dtgv3.RowCount = NumeroTamanio;
                dtgv3.ColumnCount = NumeroTamanio + 1;
                //Creo un ciclo que se encargue de crear el numero de celdas que seran ocupadas
                
                for (int i = 0; i < dtgv3.ColumnCount - 1; i++)
                {
                    //Creo el ancho de las columnas de X
                    dtgv3.Columns[i].Width = 50;
                    //Agrego el nobre a las columnas
                    dtgv3.Columns[i].HeaderText = "X" + (i + 1);
                }
                //Se establece el ancho actual de la columna del Resultado
                dtgv3.Columns[dtgv3.ColumnCount - 1].Width = 50;
                //Se agrega el nombre de la columna 
                dtgv3.Columns[dtgv3.ColumnCount - 1].HeaderText = "R";
            }
            
            
            catch (Exception ex)
            {
                String Error = ex.Message;
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBoxResultados.Text = "";
            dtgv3.Rows.Clear();
            indicador = 0;
            z = 0;
            Ayuda = 0;
            x = 0;
            y = 0;
            ValorSuma = 0;
            valorResultado = "";
            Cambiante = 0;
        }


        //Este evento click me permitira retrocer al form MenuUnidad3
        private void atras_Click(object sender, EventArgs e)
        {
            MenuUnidad3 regresar = new MenuUnidad3();
            this.Hide();
            regresar.Show();
        }

        //Aquí declaro mis variables globales, por que las utlizare en toda la clase
        String valorResultado = "";
        Double indicador = 0;
        int z = 0;
        Double Ayuda = 0;
        Double ValorSuma = 0;
        int Cambiante = 0;




















        private void dtgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gauss_Load(object sender, EventArgs e)
        {

        }
        

    }
    
}
