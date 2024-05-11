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
    public partial class iterativosecuencial : Form
    {
        public iterativosecuencial()
        {
            InitializeComponent();
        }

        //Es necesario aclarar que el metodo de Gauss-Seidel y el metodo iterativo secuencial es practicamente lo mismo
        //la unica diferencia radica en que en el iterativo secuencial se aplica a ecuaciones no lineales, por lo tanto
        //utilice y recicle codigo


        //Declaro las variables que utilizare mas adelante
        string[] ecuaciones = new string[10];
        string[] valores = new string[10];
        public int contador = 0;
        int y = 1;

        //No es nada, solo un mal click
        private void iterativosecuencial_Load(object sender, EventArgs e)
        {

        }
        //Me permitura agregar una nueva ecuacion 
        //Es un evento click de un boton
        private void agregarNuevaEcuacion_Click(object sender, EventArgs e)
        {
            tbEcuaciones.Enabled = true;
            tbValorIn.Enabled = true;
            tbEcuaciones.Text = "";
            tbValorIn.Text = "";
            //Hago que aumente 1 a 1
            y++;
            agregarNuevaEcuacion.Enabled = false;
            resolverEcuaciones.Enabled = false;
            aña.Enabled = false;
        }
        //Me permite añadir las ecuaciones que se insertaron el los
        //Text boxes para tenerlas hay y mostrarlas como no.
        private void aña_Click(object sender, EventArgs e)
        {
            ecuaciones[contador] = tbEcuaciones.Text;
            //hago que aumente 1 a 1
            contador++;
            //Ultilizo en dtgv mas el cca y la ecuacion quye se fue insertada
            dgv_Ecua.Rows.Add("X" + contador + "= " + tbEcuaciones.Text);
            agregarNuevaEcuacion.Enabled = true;
            tbEcuaciones.Enabled = false;
            tbValorIn.Enabled = false;
            DataGridViewTextBoxColumn dt = new DataGridViewTextBoxColumn();
            //configuro
            dt.HeaderText = "X" + y.ToString();
            dt.Width = 100;
            dt.FillWeight = 100;
            //Asigno a columnas
            dgvTabla.Columns.Add(dt);
            valores[y - 1] = tbValorIn.Text;
            ecuaciones[y - 1] = tbEcuaciones.Text;
            aña.Enabled = false;
        }
        //Creo un metodo para la tabla de ecuaciones
        private void tbEcuaciones_TextChanged(object sender, EventArgs e)
        {
            aña.Enabled = true;
            resolverEcuaciones.Enabled = true;
        }
        //Me permite retroceder hacia atras como su nombre lo dice
        //Tambien es un evento
        private void atras_Click(object sender, EventArgs e)
        {
            MenuUnidad3 regresar = new MenuUnidad3();
            this.Hide();
            regresar.Show();
        }
        //Creo el evento click resolver que dara los DatoNuevoAs de las EcuaOfre dadas anteriormente
        private void resolverEcuaciones_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= y; i++)
            {

                DataGridViewTextBoxColumn dt = new DataGridViewTextBoxColumn();
                dt.HeaderText = "Ea" + i;
                dt.Width = 100;
                dt.FillWeight = 100;
                dgvTabla.Columns.Add(dt);
            }
            int columnas = 1;
            dgvTabla.Rows.Add();
            for (int i = 0; i < y; i++)
            {
                dgvTabla.Rows[0].Cells[i + 1].Value = valores[i];
            }
            while (true)
            {
                dgvTabla.Rows.Add();
                for (int i = 0; i < y; i++)
                {
                    //utilizo la libreria calculus para crear un objeto, el cual necesitare
                    Calculo formula = new Calculo();
                    int cont = 0;
                    string nuevo = "";
                    while (true)
                    {

                        if (ecuaciones[i].Substring(cont, 1) == "x")
                        {
                            if (ecuaciones[i].Substring(cont + 1, 1) == "1")
                            {
                                nuevo = nuevo + "a";
                                cont++;

                            }
                            else if (ecuaciones[i].Substring(cont + 1, 1) == "2")
                            {
                                nuevo = nuevo + "b";
                                cont++;

                            }
                            else if (ecuaciones[i].Substring(cont + 1, 1) == "3")
                            {
                                nuevo = nuevo + "c";
                                cont++;

                            }
                            else if (ecuaciones[i].Substring(cont + 1, 1) == "4")
                            {
                                nuevo = nuevo + "d";
                                cont++;

                            }
                            else if (ecuaciones[i].Substring(cont + 1, 1) == "5")
                            {
                                nuevo = nuevo + "e";
                                cont++;

                            }
                            else if (ecuaciones[i].Substring(cont + 1, 1) == "6")
                            {
                                nuevo = nuevo + "f";
                                cont++;

                            }
                        }

                        else
                        {
                            nuevo = nuevo + ecuaciones[i].Substring(cont, 1);

                            if (cont == (ecuaciones[i].Length) - 1)
                            {
                                break;
                            }
                            else if (ecuaciones[i].Substring(cont + 1, 1) == "x")
                            {
                                if (ecuaciones[i].Substring(cont, 1) != "+" && ecuaciones[i].Substring(cont, 1) != "-" && ecuaciones[i].Substring(cont, 1) != "/" && ecuaciones[i].Substring(cont, 1) != "(" && ecuaciones[i].Substring(cont, 1) != ")")
                                {
                                    nuevo = nuevo + "*";
                                }

                            }

                        }
                        if (cont == (ecuaciones[i].Length) - 1)
                        {
                            break;
                        }
                        cont++;

                    }
                    cont = 0;
                    string calculo = "";
                    double ValorObtenido = 0;
                    double ea = 0;
                    bool conjunto = false;
                    string aux = nuevo;
                    int star = 0;
                    aux = aux + "$";
                    string operador = "";
                    if (aux.Substring(cont, 1) == "(")
                    {
                        cont++;
                        if (aux.Substring(cont, 1) == "-")
                        {
                            operador = "-";
                            cont++;
                            star = 2;
                        }
                        else
                        {
                            star = 1;
                        }

                    }
                    else if (aux.Substring(cont, 1) == "-")
                    {
                        operador = "-";
                        cont++;
                        star = 1;
                    }
                    while (true)
                    {
                        if (aux.Substring(cont, 1) == "a")
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == "^")
                            {
                                cont++;
                                calculo = calculo + aux.Substring(cont, 1);
                                while (true)
                                {
                                    if (aux.Substring(cont + 1, 1) != "+" && aux.Substring(cont + 1, 1) != "-" && aux.Substring(cont + 1, 1) != ")" && aux.Substring(cont + 1, 1) != "(" && aux.Substring(cont + 1, 1) != "*" && aux.Substring(cont + 1, 1) != "/")
                                    {
                                        cont++;
                                        calculo = calculo + aux.Substring(cont, 1);

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            formula.Sintaxis(calculo, 'a');
                            if (operador == "")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[0]));
                            }
                            else if (operador == "+")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[0]));
                            }
                            else if (operador == "-")
                            {
                                ValorObtenido = ValorObtenido - formula.EvaluaFx(Convert.ToDouble(valores[0]));
                            }
                            else if (operador == "*")
                            {
                                ValorObtenido = ValorObtenido * formula.EvaluaFx(Convert.ToDouble(valores[0]));
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
                                                ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "*")
                            {
                                operador = "*";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(calculo.Length + star, (aux.Length - calculo.Length) - star);
                            star = 1;
                            calculo = "";
                            cont = 0;

                        }
                        else if (aux.Substring(cont, 1) == "b")
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == "^")
                            {
                                cont++;
                                calculo = calculo + aux.Substring(cont, 1);
                                while (true)
                                {
                                    if (aux.Substring(cont + 1, 1) != "+" && aux.Substring(cont + 1, 1) != "-" && aux.Substring(cont + 1, 1) != ")" && aux.Substring(cont + 1, 1) != "(" && aux.Substring(cont + 1, 1) != "*" && aux.Substring(cont + 1, 1) != "/")
                                    {
                                        cont++;
                                        calculo = calculo + aux.Substring(cont, 1);

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            formula.Sintaxis(calculo, 'b');
                            if (operador == "")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[1]));
                            }
                            else if (operador == "+")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[1]));
                            }
                            else if (operador == "-")
                            {
                                ValorObtenido = ValorObtenido - formula.EvaluaFx(Convert.ToDouble(valores[1]));
                            }
                            else if (operador == "*")
                            {
                                ValorObtenido = ValorObtenido * formula.EvaluaFx(Convert.ToDouble(valores[0]));
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
                                                ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "*")
                            {
                                operador = "*";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(calculo.Length + star, (aux.Length - calculo.Length) - star);
                            star = 1;
                            calculo = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "c")
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == "^")
                            {
                                cont++;
                                calculo = calculo + aux.Substring(cont, 1);
                                while (true)
                                {
                                    if (aux.Substring(cont + 1, 1) != "+" && aux.Substring(cont + 1, 1) != "-" && aux.Substring(cont + 1, 1) != ")" && aux.Substring(cont + 1, 1) != "(" && aux.Substring(cont + 1, 1) != "*" && aux.Substring(cont + 1, 1) != "/")
                                    {
                                        cont++;
                                        calculo = calculo + aux.Substring(cont, 1);

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            formula.Sintaxis(calculo, 'c');
                            if (operador == "")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[2]));
                            }
                            else if (operador == "+")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[2]));
                            }
                            else if (operador == "-")
                            {
                                ValorObtenido = ValorObtenido - formula.EvaluaFx(Convert.ToDouble(valores[2]));
                            }
                            else if (operador == "*")
                            {
                                ValorObtenido = ValorObtenido * formula.EvaluaFx(Convert.ToDouble(valores[0]));
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
                                                ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "*")
                            {
                                operador = "*";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(calculo.Length + star, (aux.Length - calculo.Length) - star);
                            star = 1;
                            calculo = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "d")
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == "^")
                            {
                                cont++;
                                calculo = calculo + aux.Substring(cont, 1);
                                while (true)
                                {
                                    if (aux.Substring(cont + 1, 1) != "+" && aux.Substring(cont + 1, 1) != "-" && aux.Substring(cont + 1, 1) != ")" && aux.Substring(cont + 1, 1) != "(" && aux.Substring(cont + 1, 1) != "*" && aux.Substring(cont + 1, 1) != "/")
                                    {
                                        cont++;
                                        calculo = calculo + aux.Substring(cont, 1);

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            formula.Sintaxis(calculo, 'd');
                            if (operador == "")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[3]));
                            }
                            else if (operador == "+")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[3]));
                            }
                            else if (operador == "-")
                            {
                                ValorObtenido = ValorObtenido - formula.EvaluaFx(Convert.ToDouble(valores[3]));
                            }
                            else if (operador == "*")
                            {
                                ValorObtenido = ValorObtenido * formula.EvaluaFx(Convert.ToDouble(valores[0]));
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
                                                ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "*")
                            {
                                operador = "*";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(calculo.Length + star, (aux.Length - calculo.Length) - star);
                            star = 1;
                            calculo = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "e")
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == "^")
                            {
                                cont++;
                                calculo = calculo + aux.Substring(cont, 1);
                                while (true)
                                {
                                    if (aux.Substring(cont + 1, 1) != "+" && aux.Substring(cont + 1, 1) != "-" && aux.Substring(cont + 1, 1) != ")" && aux.Substring(cont + 1, 1) != "(" && aux.Substring(cont + 1, 1) != "*" && aux.Substring(cont + 1, 1) != "/")
                                    {
                                        cont++;
                                        calculo = calculo + aux.Substring(cont, 1);

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            formula.Sintaxis(calculo, 'e');
                            if (operador == "")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[4]));
                            }
                            else if (operador == "+")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[4]));
                            }
                            else if (operador == "-")
                            {
                                ValorObtenido = ValorObtenido - formula.EvaluaFx(Convert.ToDouble(valores[4]));
                            }
                            else if (operador == "*")
                            {
                                ValorObtenido = ValorObtenido * formula.EvaluaFx(Convert.ToDouble(valores[0]));
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
                                                ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "*")
                            {
                                operador = "*";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(calculo.Length + star, (aux.Length - calculo.Length) - star);
                            star = 1;
                            calculo = "";
                            cont = 0;
                        }
                        else if (aux.Substring(cont, 1) == "f")
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == "^")
                            {
                                cont++;
                                calculo = calculo + aux.Substring(cont, 1);
                                while (true)
                                {
                                    if (aux.Substring(cont + 1, 1) != "+" && aux.Substring(cont + 1, 1) != "-" && aux.Substring(cont + 1, 1) != ")" && aux.Substring(cont + 1, 1) != "(" && aux.Substring(cont + 1, 1) != "*" && aux.Substring(cont + 1, 1) != "/")
                                    {
                                        cont++;
                                        calculo = calculo + aux.Substring(cont, 1);

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            formula.Sintaxis(calculo, 'f');
                            if (operador == "")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[5]));
                            }
                            else if (operador == "+")
                            {
                                ValorObtenido = ValorObtenido + formula.EvaluaFx(Convert.ToDouble(valores[5]));
                            }
                            else if (operador == "-")
                            {
                                ValorObtenido = ValorObtenido - formula.EvaluaFx(Convert.ToDouble(valores[5]));
                            }
                            else if (operador == "*")
                            {
                                ValorObtenido = ValorObtenido * formula.EvaluaFx(Convert.ToDouble(valores[0]));
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
                                                ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                                ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "-")
                            {
                                operador = "-";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "*")
                            {
                                operador = "*";
                                cont++;
                            }
                            else if (aux.Substring(cont + 1, 1) == "$")
                            {
                                break;
                            }
                            aux = aux.Substring(calculo.Length + star, (aux.Length - calculo.Length) - star);
                            star = 1;
                            calculo = "";
                            cont = 0;
                        }

                        else
                        {
                            calculo = calculo + aux.Substring(cont, 1);
                            if (aux.Substring(cont + 1, 1) == ")")
                            {
                                if (operador == "+")
                                {
                                    ValorObtenido = ValorObtenido + Convert.ToDouble(calculo);
                                }
                                else if (operador == "-")
                                {
                                    ValorObtenido = ValorObtenido - Convert.ToDouble(calculo);
                                }
                                else if (operador == "/")
                                {
                                    ValorObtenido = ValorObtenido / Convert.ToDouble(calculo);
                                }
                                else if (operador == "*")
                                {
                                    ValorObtenido = ValorObtenido * Convert.ToDouble(calculo);
                                }
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
                                            ValorObtenido = ValorObtenido / Convert.ToDouble(divicion);
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
                                            ValorObtenido = ValorObtenido * Convert.ToDouble(divicion);
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
                                            ValorObtenido = ValorObtenido + Convert.ToDouble(divicion);
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
                                            ValorObtenido = ValorObtenido - Convert.ToDouble(divicion);
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
                        cont++;

                    }
                    dgvTabla.Rows[columnas].Cells[i + 1].Value = ValorObtenido;
                    valores[i] = ValorObtenido.ToString();
                    ea = Math.Abs(((ValorObtenido - Convert.ToDouble(dgvTabla.Rows[columnas - 1].Cells[i + 1].Value.ToString())) / ValorObtenido) * 100);
                    dgvTabla.Rows[columnas].Cells[(i + 1) + y].Value = ea;
                }
                int eas = 0;
                double es = Convert.ToDouble(tbEs.Text);
                for (int i = 0; i < y; i++)
                {
                    if (Convert.ToDouble(dgvTabla.Rows[columnas].Cells[(i + 1) + y].Value.ToString()) < es)
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


    }
}
