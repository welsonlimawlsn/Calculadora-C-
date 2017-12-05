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
                    valor1 = int.Parse(algoritmo.Substring(0, algoritmo.IndexOf(c)));
                    valor2 = int.Parse(algoritmo.Substring(algoritmo.IndexOf(c) + 1));
                    operacao = c;
                }
            }
            Console.WriteLine(valor1);
            Console.WriteLine(operacao);
            Console.WriteLine(valor2);
        }
    }
}
