using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        //atributos
        private double Valor1, Valor2;
        private string operacion;


        public Form1()
        {
            InitializeComponent();
        }

        //botones numericos
        private void bt_uno_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "1";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "1";
            }
        }

        private void bt_dos_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "2";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "2";
            }
        }

        private void bt_tres_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "3";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "3";
            }
        }

        private void bt_cuadro_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "4";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "4";
            }
        }

        private void bt_cinco_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "5";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "5";
            }
        }

        private void bt_seis_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "6";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "6";
            }
        }

        private void bt_siete_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "7";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "7";
            }
        }

        private void bt_ocho_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "8";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "8";
            }
        }

        private void bt_nueve_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "9";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "9";
            }
        }

        private void bt_cero_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = "0";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + "0";
            }
        }

        private void bt_punto_Click(object sender, EventArgs e)
        {
            if (tbox_resultado.Text == "")
            {
                tbox_resultado.Text = ".";
            }
            else
            {
                tbox_resultado.Text = tbox_resultado.Text + ".";
            }
        }

        //limpiar 
        private void bt_clear_Click(object sender, EventArgs e)
        {
            Valor1 = 0;
            Valor2 = 0;
            tbox_resultado.Clear();
            tbox_resultado.Focus();
        }

        //sumando, restando, dividir, multiplicar (botones)
        private void bt_mas_Click(object sender, EventArgs e)
        {
            try
            {
                Valor1 = Convert.ToDouble(tbox_resultado.Text);
                operacion = "+";
                tbox_resultado.Clear();
                tbox_resultado.Focus();
            }catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
        }

        private void bt_menos_Click(object sender, EventArgs e)
        {
            try
            {
                Valor1 = Convert.ToDouble(tbox_resultado.Text);
                operacion = "-";
                tbox_resultado.Clear();
                tbox_resultado.Focus();
            }
            catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Valor1 = Convert.ToDouble(tbox_resultado.Text);
                operacion = "*";
                tbox_resultado.Clear();
                tbox_resultado.Focus();
            }
            catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                Valor1 = Convert.ToDouble(tbox_resultado.Text);
                operacion = "/";
                tbox_resultado.Clear();
                tbox_resultado.Focus();
            }
            catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
        }

        //boton igual
        private void bt_igualdad_Click(object sender, EventArgs e)
        {
            try
            {
                Valor2 = Convert.ToDouble(tbox_resultado.Text);
                tbox_resultado.Text = realizarOperacion(Valor1, Valor2).ToString();
            }
            catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
        }

        //realizar operaccion
        private double realizarOperacion(double valor1, double valor2)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = Valor1 + Valor2;
                    break;

                case "-":
                    resultado = Valor1 - Valor2;
                    break;

                case "*":
                    resultado = Valor1 * Valor2;
                    break;

                case "/":
                    resultado = Valor1 / Valor2;
                    break;

                default:
                    tbox_resultado.Text = "Error en el operador";
                    break;
            }

            return resultado;
        }
    }
}
