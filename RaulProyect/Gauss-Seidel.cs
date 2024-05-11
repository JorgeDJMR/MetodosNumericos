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
    public partial class gaussseidel : Form
    {
        public gaussseidel()
        {
            InitializeComponent();
        }
        //declaro las variables que utilizare a lo largo del programa

        public int cca = 0;
        int y = 1;
        string[] EcuaOfre = new string[10];
        string[] valores = new string[10];
        

  
        
        private void gaussseidel_Load(object sender, EventArgs e)
        {

        }
        //Creo un metodo para la ecuacion que meteran
        private void ecuacionDada_TextChanged(object sender, EventArgs e)

        {
            insertarValores.Enabled = true;
            resolver.Enabled = true;
        }
        //Se encarga de agarrar los valores que le das y guardarlos
        //Evento Click
        private void insertarValores_Click(object sender, EventArgs e)
        {
            EcuaOfre[cca] = ecuacionDada.Text;
            //Hago que el cca avance
            cca++;
            //Ultilizo en dtgv mas el cca y la ecuacion quye se fue insertada
            dtgvAñadidas.Rows.Add("X" + cca + "= " + ecuacionDada.Text);
            nuevaEcuacion.Enabled = true;
            ecuacionDada.Enabled = false;
            valorInicial.Enabled = false;
            DataGridViewTextBoxColumn dt = new DataGridViewTextBoxColumn();
            //configuro
            dt.HeaderText = "X" + y.ToString();
            dt.Width = 100;
            dt.FillWeight = 100;
            //Asigno a columnas
            dtgvTabla.Columns.Add(dt);
            valores[y - 1] = valorInicial.Text;
            EcuaOfre[y - 1] = ecuacionDada.Text;
            insertarValores.Enabled = false;
        }

        //Me permite retroceder hacia atras como su nombre lo dice
        //Tambien es un evento
        private void atras_Click(object sender, EventArgs e)
        {
            MenuUnidad3 regresar = new MenuUnidad3();
            this.Hide();
            regresar.Show();
        }
        //Me permite agregar una nueva ecuacion 
        private void nuevaEcuacion_Click(object sender, EventArgs e)
        {
            ecuacionDada.Enabled = true;
            valorInicial.Enabled = true;
            ecuacionDada.Text = "";
            valorInicial.Text = "";
            //Hago que aumente
            y++;
            nuevaEcuacion.Enabled = false;
            resolver.Enabled = false;
            insertarValores.Enabled = false;
        }

        //Creo el evento click resolver que dara los DatoNuevoAs de las EcuaOfre dadas anteriormente
        private void resolver_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= y; i++)
            {
                DataGridViewTextBoxColumn dt = new DataGridViewTextBoxColumn();
                dt.HeaderText = "Ea" + i;
                dt.Width = 100;
                dt.FillWeight = 100;
                dtgvTabla.Columns.Add(dt);
            }
            int columnas = 1;
            dtgvTabla.Rows.Add();
            for (int i = 0; i < y; i++)
            {
                dtgvTabla.Rows[0].Cells[i + 1].Value = valores[i];
            }
            while (true)
            {
                dtgvTabla.Rows.Add();
                for (int i = 0; i < y; i++)
                {
                    //utilizo la libreria calculus para crear un objeto, el cual necesitare
                    Calculo formula = new Calculo();
                    int cont = 0;
                    string nuevo = "";
                    //Mientras que este sea verdadero no parara
                    while (true)
                    {

                        if (EcuaOfre[i].Substring(cont, 1) == "x")
                        {
                            if (EcuaOfre[i].Substring(cont + 1, 1) == "1")
                            {
                                nuevo = nuevo + "a";
                                cont++;

                            }
                            else if (EcuaOfre[i].Substring(cont + 1, 1) == "2")
                            {
                                nuevo = nuevo + "b";
                                cont++;

                            }
                            else if (EcuaOfre[i].Substring(cont + 1, 1) == "3")
                            {
                                nuevo = nuevo + "c";
                                cont++;

                            }
                            else if (EcuaOfre[i].Substring(cont + 1, 1) == "4")
                            {
                                nuevo = nuevo + "d";
                                cont++;

                            }
                            else if (EcuaOfre[i].Substring(cont + 1, 1) == "5")
                            {
                                nuevo = nuevo + "e";
                                cont++;

                            }
                            else if (EcuaOfre[i].Substring(cont + 1, 1) == "6")
                            {
                                nuevo = nuevo + "f";
                                cont++;

                            }
                        }

                        else
                        {
                            nuevo = nuevo + EcuaOfre[i].Substring(cont, 1);

                            if (cont == (EcuaOfre[i].Length) - 1)
                            {
                                break;
                            }
                            else if (EcuaOfre[i].Substring(cont + 1, 1) == "x")
                            {
                                if (EcuaOfre[i].Substring(cont, 1) != "+" && EcuaOfre[i].Substring(cont, 1) != "-" && EcuaOfre[i].Substring(cont, 1) != "/" && EcuaOfre[i].Substring(cont, 1) != "(" && EcuaOfre[i].Substring(cont, 1) != ")")
                                {
                                    nuevo = nuevo + "*";
                                }

                            }

                        }
                        if (cont == (EcuaOfre[i].Length) - 1)
                        {
                            break;
                        }
                        cont++;

                    }
                    //igualo el cont a cero
                    double DatoNuevoA = 0;
                    double ea = 0;
                    cont = 0;
                    string resolvers = "";
                    string aux = nuevo;
                    aux = aux + "$";
                    string operador = "";
                    bool conjunto = false;

                    if (aux.Substring(cont, 1) == "-")
                    {
                        operador = "-";
                        cont++;
                    }
                    while (true)
                    {
                        if (aux.Substring(cont, 1) == "a")
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                            formula.Sintaxis(resolvers, 'a');
                            if (operador == "")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[0]));
                            }
                            else if (operador == "+")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[0]));
                            }
                            else if (operador == "-")
                            {
                                DatoNuevoA = DatoNuevoA - formula.EvaluaFx(Convert.ToDouble(valores[0]));
                            }
                            if (conjunto == true)
                            {
                                if (aux.Substring(cont + 1, 1) == ")")
                                {
                                    cont++;
                                    conjunto = false;
                                    if (aux.Substring(cont + 1, 1) == "/")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA / Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "*")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA * Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "+")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA + Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }

                                    }
                                    else if (aux.Substring(cont + 1, 1) == "-")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA - Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            if (aux.Substring(cont + 1, 1) == "+")
                            {
                                operador = "+";

                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";

                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(resolvers.Length + 1, (aux.Length - resolvers.Length) - 1);
                            resolvers = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "b")
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                            formula.Sintaxis(resolvers, 'b');
                            if (operador == "")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[1]));
                            }
                            else if (operador == "+")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[1]));
                            }
                            else if (operador == "-")
                            {
                                DatoNuevoA = DatoNuevoA - formula.EvaluaFx(Convert.ToDouble(valores[1]));
                            }
                            if (conjunto == true)
                            {
                                if (aux.Substring(cont + 1, 1) == ")")
                                {
                                    cont++;
                                    conjunto = false;
                                    if (aux.Substring(cont + 1, 1) == "/")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA / Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "*")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA * Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "+")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA + Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }

                                    }
                                    else if (aux.Substring(cont + 1, 1) == "-")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA - Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            if (aux.Substring(cont + 1, 1) == "+")
                            {
                                operador = "+";

                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";

                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(resolvers.Length + 1, (aux.Length - resolvers.Length) - 1);
                            resolvers = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "c")
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                            formula.Sintaxis(resolvers, 'c');
                            if (operador == "")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[2]));
                            }
                            else if (operador == "+")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[2]));
                            }
                            else if (operador == "-")
                            {
                                DatoNuevoA = DatoNuevoA - formula.EvaluaFx(Convert.ToDouble(valores[2]));
                            }
                            if (conjunto == true)
                            {
                                if (aux.Substring(cont + 1, 1) == ")")
                                {
                                    cont++;
                                    conjunto = false;
                                    if (aux.Substring(cont + 1, 1) == "/")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA / Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "*")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA * Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "+")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA + Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }

                                    }
                                    else if (aux.Substring(cont + 1, 1) == "-")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA - Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            if (aux.Substring(cont + 1, 1) == "+")
                            {
                                operador = "+";

                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";

                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(resolvers.Length + 1, (aux.Length - resolvers.Length) - 1);
                            resolvers = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "d")
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                            formula.Sintaxis(resolvers, 'd');
                            if (operador == "")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[3]));
                            }
                            else if (operador == "+")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[3]));
                            }
                            else if (operador == "-")
                            {
                                DatoNuevoA = DatoNuevoA - formula.EvaluaFx(Convert.ToDouble(valores[3]));
                            }
                            if (conjunto == true)
                            {
                                if (aux.Substring(cont + 1, 1) == ")")
                                {
                                    cont++;
                                    conjunto = false;
                                    if (aux.Substring(cont + 1, 1) == "/")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA / Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "*")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA * Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "+")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA + Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }

                                    }
                                    else if (aux.Substring(cont + 1, 1) == "-")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA - Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            if (aux.Substring(cont + 1, 1) == "+")
                            {
                                operador = "+";

                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";

                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(resolvers.Length + 1, (aux.Length - resolvers.Length) - 1);
                            resolvers = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "e")
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                            formula.Sintaxis(resolvers, 'e');
                            if (operador == "")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[4]));
                            }
                            else if (operador == "+")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[4]));
                            }
                            else if (operador == "-")
                            {
                                DatoNuevoA = DatoNuevoA - formula.EvaluaFx(Convert.ToDouble(valores[4]));
                            }
                            if (conjunto == true)
                            {
                                if (aux.Substring(cont + 1, 1) == ")")
                                {
                                    cont++;
                                    conjunto = false;
                                    if (aux.Substring(cont + 1, 1) == "/")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA / Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "*")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA * Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "+")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA + Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }

                                    }
                                    else if (aux.Substring(cont + 1, 1) == "-")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA - Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            if (aux.Substring(cont + 1, 1) == "+")
                            {
                                operador = "+";

                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";

                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(resolvers.Length + 1, (aux.Length - resolvers.Length) - 1);
                            resolvers = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "f")
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                            formula.Sintaxis(resolvers, 'f');
                            if (operador == "")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[5]));
                            }
                            else if (operador == "+")
                            {
                                DatoNuevoA = DatoNuevoA + formula.EvaluaFx(Convert.ToDouble(valores[5]));
                            }
                            else if (operador == "-")
                            {
                                DatoNuevoA = DatoNuevoA - formula.EvaluaFx(Convert.ToDouble(valores[5]));
                            }
                            if (conjunto == true)
                            {
                                if (aux.Substring(cont + 1, 1) == ")")
                                {
                                    cont++;
                                    conjunto = false;
                                    if (aux.Substring(cont + 1, 1) == "/")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA / Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "*")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA * Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    else if (aux.Substring(cont + 1, 1) == "+")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA + Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }

                                    }
                                    else if (aux.Substring(cont + 1, 1) == "-")
                                    {

                                        cont = cont + 2;
                                        string divicion = "";
                                        while (true)
                                        {
                                            if (aux.Substring(cont + 1, 1) == "$")
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                DatoNuevoA = DatoNuevoA - Convert.ToDouble(divicion);
                                                break;
                                            }
                                            else
                                            {
                                                divicion = divicion + aux.Substring(cont, 1);
                                                cont++;
                                            }
                                        }
                                    }
                                    break;
                                }

                            }
                            if (aux.Substring(cont + 1, 1) == "+")
                            {
                                operador = "+";

                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";

                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(resolvers.Length + 1, (aux.Length - resolvers.Length) - 1);
                            resolvers = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "(")
                        {
                            conjunto = true;
                        }
                        else
                        {
                            resolvers = resolvers + aux.Substring(cont, 1);
                        }
                        cont++;

                    }
                    dtgvTabla.Rows[columnas].Cells[i + 1].Value = DatoNuevoA;
                    valores[i] = DatoNuevoA.ToString();
                    ea = Math.Abs(((DatoNuevoA - Convert.ToDouble(dtgvTabla.Rows[columnas - 1].Cells[i + 1].Value.ToString())) / DatoNuevoA) * 100);
                    dtgvTabla.Rows[columnas].Cells[(i + 1) + y].Value = ea;
                }
                int eas = 0;
                double es = Convert.ToDouble(errorEsperado.Text);
                for (int i = 0; i < y; i++)
                {
                    if (Convert.ToDouble(dtgvTabla.Rows[columnas].Cells[(i + 1) + y].Value.ToString()) < es)
                    {
                        eas = eas + 1;
                    }

                }
                if (eas == y)
                {
                    break;
                }
                columnas++;

            }
        }

        //Creo el metodo que limpiara lo que este escrito en los text boxes, limpia TODO
        private void limpiar_Click(object sender, EventArgs e)
        {
            //Me permite borrar los datos que se ingresaron en la tabla en los textbox
            ecuacionDada.Text = " ";
            errorEsperado.Text = " ";
            valorInicial.Text = " ";
            dtgvAñadidas.Rows.Clear();
            dtgvTabla.Rows.Clear();
        }

        //Limpia solo los datos puestos
        private void limpiarDatos_Click(object sender, EventArgs e)
        {
            ecuacionDada.Text = " ";
            errorEsperado.Text = " ";
            valorInicial.Text = " ";
        }
    }
    
}
