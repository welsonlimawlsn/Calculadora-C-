using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            char operacao = ' ';
            string algoritmo = textBoxAlgoritimo.Text;
            string sinais = "+-/*";

            foreach(char c in sinais)
            {
                if(algoritmo.IndexOf(c) != -1)
                {
                    try
                    {
                        valor1 = int.Parse(algoritmo.Substring(0, algoritmo.IndexOf(c)));
                        valor2 = int.Parse(algoritmo.Substring(algoritmo.IndexOf(c) + 1));
                        operacao = c;
                    } catch (FormatException error)
                    {
                        MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (operacao != ' ')
                textBoxAlgoritimo.Text = this.RealizarOperacao(operacao, valor1, valor2).ToString();
            else
                MessageBox.Show("Ocorreu algum erro! Verifique a sintaxe da conta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxAlgoritimo.Focus();
            textBoxAlgoritimo.SelectAll();
        }
        private double RealizarOperacao(char operacao, int valor1, int valor2)
        {
            switch (operacao)
            {
                case '+':
                    return valor1 + valor2;
                case '-':
                    return valor1 - valor2;
                case '*':
                    return valor1 * valor2;
                case '/':
                    return (double)valor1 / valor2;
                default:
                    return 0;
            }
        }

        private void textBoxAlgoritimo_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //    buttonCalcular_Click(buttonCalcular, EventArgs.Empty);
            if (e.KeyCode == Keys.Escape)
                textBoxAlgoritimo.Text = "";
        }
    }
}
