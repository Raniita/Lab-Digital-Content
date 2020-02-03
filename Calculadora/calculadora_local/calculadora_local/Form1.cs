using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double op1 = 0.0;
        private double op2 = 0.0;
        private double resultado;
        private Boolean operando = true;

        // Lista de resultados
        List<string> items = new List<string>();

        // Creacion del objeto remoto
        objeto_op.operaciones op = new objeto_op.operaciones();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) ||
                                   e.KeyChar == 8 ||
                     e.KeyChar == Char.Parse("-") ||
                      e.KeyChar == Char.Parse("."));
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) ||
                                   e.KeyChar == 8 ||
                     e.KeyChar == Char.Parse("-") ||
                      e.KeyChar == Char.Parse("."));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out op1) == true &&
                   double.TryParse(textBox2.Text, out op2) == true)
            {
                op1 = double.Parse(textBox1.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                op2 = double.Parse(textBox2.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                resultado = op.sumar(op1,op2);
                items.Add("Resultado de la suma: " + resultado.ToString());
                listBox1.DataSource = null;
                listBox1.DataSource = items;

                // Limpiamos los valores introducidos
                textBox1.Clear();
                textBox2.Clear();

                // Volvemos al primer operando
                operando = true;
            }
            else
            {
                MessageBox.Show("Has introducido un valor no numérico", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out op1) == true &&
                  double.TryParse(textBox2.Text, out op2) == true)
            {
                op1 = double.Parse(textBox1.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                op2 = double.Parse(textBox2.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                resultado = op.restar(op1, op2);
                items.Add("Resultado de la resta: " + resultado.ToString());
                listBox1.DataSource = null;
                listBox1.DataSource = items;

                // Limpiamos los valores introducidos
                textBox1.Clear();
                textBox2.Clear();

                // Volvemos al primer operando
                operando = true;
            }
            else
            {
                MessageBox.Show("Has introducido un valor no numérico", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out op1) == true &&
                  double.TryParse(textBox2.Text, out op2) == true)
            {
                op1 = double.Parse(textBox1.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                op2 = double.Parse(textBox2.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                resultado = op.multiplicar(op1, op2);
                items.Add("Resultado de la multiplicación: " + resultado.ToString());
                listBox1.DataSource = null;
                listBox1.DataSource = items;

                // Limpiamos los valores introducidos
                textBox1.Clear();
                textBox2.Clear();

                // Volvemos al primer operando
                operando = true;
            }
            else
            {
                MessageBox.Show("Has introducido un valor no numérico", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out op1) == true &&
                  double.TryParse(textBox2.Text, out op2) == true)
            {
                op1 = double.Parse(textBox1.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                op2 = double.Parse(textBox2.Text, System.Globalization.NumberStyles.Any,
                                   System.Globalization.NumberFormatInfo.InvariantInfo);
                resultado = op.dividir(op1, op2);
                items.Add("Resultado de la division: " + resultado.ToString());
                listBox1.DataSource = null;
                listBox1.DataSource = items;

                // Limpiamos los valores introducidos
                textBox1.Clear();
                textBox2.Clear();

                // Volvemos al primer operando
                operando = true;
            }
            else
            {
                MessageBox.Show("Has introducido un valor no numérico", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            number("1");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operando == true)
            {
                operando = false;
            }
            else
            {
                operando = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number("2");
        }

        private void number(String num)
        {
            if (operando == true)
            {
                textBox1.Text = textBox1.Text + num;
            }
            else
            {
                textBox2.Text = textBox2.Text + num;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number("3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number("4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number("7");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            number("8");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number("9");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number("0");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number(".");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number("-");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
