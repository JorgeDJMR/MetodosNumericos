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
    public partial class ApolloJacobi : Form
    {
        public ApolloJacobi()
        {
            InitializeComponent();
        }


  
        //Se crea una funcion para llenar la primera fila de la matriz
        void InicializarMatriz()
        {
            DataGridViewRow filaNueva = new DataGridViewRow();
            filaNueva.CreateCells(dgvRealizarCalcs);
            for (int a = 0; a < dgvRealizarCalcs.ColumnCount; a++)
            {
                filaNueva.Cells[a].Value = 0;
                if (a > nuevoContador)
                {
                    filaNueva.Cells[a].Value = "-";
                }
            }
            dgvRealizarCalcs.Rows.Add(filaNueva);
            //Se guardan los valores iniciales de cada variable
            for (int b = 0; b < nuevoContador; b++)
            {
                variables[b] = Convert.ToDouble(filaNueva.Cells[b + 1].Value);
                valorAnterior[b] = Convert.ToDouble(filaNueva.Cells[b + 1].Value);
            }
        }

        //Realiza  todos los calculos de las variables y de los errores
        void RealizarCalculos()
        {
            Boolean condicionDeSalida = false;
            while (condicionDeSalida != true)
            {
                
                int salida = 0;
                double[] auxValoresAnteriores = new double[15];
                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.CreateCells(dgvRealizarCalcs);
                nuevaFila.Cells[0].Value = iteraciones;
                // calcula todas las variables X
                for (int a = 1; a <= nuevoContador; a++)
                {
                    nuevaFila.Cells[a].Value = ResolverEcuaciones(ecuacionesNuevas[a - 1]);
                }
                // calcula el Ea de cada variable X
                for (int b = nuevoContador + 1; b < dgvRealizarCalcs.ColumnCount; b++)
                {

                    nuevaFila.Cells[b].Value = Math.Abs(CalcularErrores(Convert.ToDouble(nuevaFila.Cells[b - nuevoContador].Value), valorAnterior[b - nuevoContador - 1]));

                }
                //creo un ciclo que almacena los valores obtenidos y los valores anteriores para luego poder llegar a utilizarlos
                for (int b = 0; b < nuevoContador; b++)
                {
                    variables[b] = Convert.ToDouble(nuevaFila.Cells[b + 1].Value);
                    valorAnterior[b] = Convert.ToDouble(nuevaFila.Cells[b + 1].Value);
                }
                dgvRealizarCalcs.Rows.Add(nuevaFila);
                iteraciones++;
                // checa si todos son menores al error esperado para romper el ciclo
                for (int b = nuevoContador + 1; b < dgvRealizarCalcs.ColumnCount; b++)
                {
                    if (Convert.ToDouble(nuevaFila.Cells[b].Value) <= nuevoEs)
                    {
                        salida++;
                    }
                }
                //Permite la salida
                if (salida == nuevoContador)
                {
                    condicionDeSalida = true;
                }
            }
        }
        //Funcion para resolver la ecuacion
        double ResolverEcuaciones(string ecuacionEntrada)
        {
            string variable = "x";
            string valorRetorno;
            //Creo un ciclo para sustituir los valores ya obtenidos en las ecuaciones
            for (int z = 1; z <= nuevoContador; z++)
            {
                variable += z.ToString();
                ecuacionEntrada = ecuacionEntrada.Replace(variable, variables[z - 1].ToString());
                variable = "x";
            }
            //Se calcula la ecuacion
            ecuacionEntrada = ecuacionEntrada.Replace(',', '.');
            //Utilizo la libreria Calculus
            Calculo formula = new Calculo();
            valorRetorno = formula.Sintaxis(ecuacionEntrada, 'x') ?
            formula.EvaluaFx(0).ToString() : "Error de sintaxis";
            return Convert.ToDouble(valorRetorno);
        }


 
        private void ResolucionMetodos_Load(object sender, EventArgs e)
        {
            //Creo las columnas para X
            string nColumnaX = "X";
            for (int i = 0; i < nuevoContador; i++)
            {
                nColumnaX += i.ToString();
                DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
                nuevaColumna.HeaderText = $"{nColumnaX} ";
                nuevaColumna.Name = "columna_" + nColumnaX;
                dgvRealizarCalcs.Columns.Add(nuevaColumna);
                nColumnaX = "X";
            }

            // Creo las columnas del Error
            string nColumnaEa = "Ea";
            for (int i = 0; i < nuevoContador; i++)
            {
                nColumnaEa += i.ToString();
                DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
                nuevaColumna.HeaderText = $"{nColumnaEa} ";
                nuevaColumna.Name = "columna_" + nColumnaEa;
                dgvRealizarCalcs.Columns.Add(nuevaColumna);
                nColumnaEa = "Ea";
            }
            InicializarMatriz();
            RealizarCalculos();
        }
        // Calculo de Ea
        double CalcularErrores(double valorActual, double valorAnterior)
        {
            return ((valorActual - valorAnterior) / valorActual) * 100;
        }

        //Creo contrusctor para asi obtener los valores desde otro formulario
        public ApolloJacobi(int nContador, string[] ecuacionesNvs, double nEs)
        {
            InitializeComponent();
            nuevoContador = nContador;
            ecuacionesNuevas = ecuacionesNvs;
            nuevoEs = nEs;
        }
        //Declaro las variables que utilizare globalmente
        int nuevoContador, iteraciones = 1;
        string[] ecuacionesNuevas = new string[5];
        double[] variables = new double[5];
        double[] valorAnterior = new double[5];
        double nuevoEs;

    }
}
