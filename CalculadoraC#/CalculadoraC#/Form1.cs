using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CalculadoraC_
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Armazena o tipo de opereção (+,- e etc).
        /// </summary>
        public char operacao;
        /// <summary>
        /// Armazena  o valor em double
        /// </summary>
        double valor1=0, valor2=0; 

        public int contar = 0;
        public int botaoigual=0;
        public string Erro;

        //private void Calculos()
        //{
        //    //double resultado=0.0;
        //    //string entrada = string.Empty;
        //    //string operando1=string.Empty;
        //    //string operando2 = entrada;
        //    //double num1, num2;
        //    //double.TryParse(operando1, out num1);
        //    //double.TryParse(operando2, out num2);
            
        //    //if (operacao == '+')
        //    //{

        //    //}
        //    //else if (operacao == '-')
        //    //{

        //    //}
        //    //else if (operacao == 'x')
        //    //{

        //    //}
        //    //else if (operacao == '÷')
        //    //{
        //    //    try
        //    //    {

        //    //    }
        //    //    catch
        //    //    {
        //    //        Erro = "Erro!";
        //    //    }
            
        //}
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BotaoC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void BotaoUm_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void BotaoDois_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void BotaoSete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void BotaoOito_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void BotaoNove_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void BotaoMultiplcacao_Click(object sender, EventArgs e)
        {
            contar++;
            textBox1.Text = textBox1.Text + "*";
        }

        private void BotaoSubtracao_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            contar++;
        }

        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case '+':
                    try
                    {
                        
                    }
                    catch 
                    {
                        
                    }
                    break;
                case '-':
                    try
                    {

                    }
                    catch
                    {

                    }
                    break;
                case 'x':
                    try
                    {

                    }
                    catch
                    {

                    }
                    break;
                case '÷':
                    try
                    {

                    }
                    catch
                    {

                    }
                    break;
            }
        }

        private void BotaoDivisao_Click(object sender, EventArgs e)
        {
            contar++;
            textBox1.Text = textBox1.Text + "÷";
            operacao = '/';
            

        }

        private void BotaoPorcentagem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void BotaoVirgula_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void BotaoFracao_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void BotaoPotencia_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^";
        }

        private void BotaoRaiz_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "²√";
        }

        private void BotaoCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void BotaoAdicao_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            contar++;
            operacao = '+';
        }

        private void BotaoZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
