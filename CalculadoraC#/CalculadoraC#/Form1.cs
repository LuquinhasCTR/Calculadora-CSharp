﻿using System;
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
        public int contar = 1;
        /// <summary>
        /// Armazena o tipo de operação
        /// </summary>
        public char operacao;

        /// <summary>
        /// Armazena os valores atribuídos
        /// </summary>
        double valor1 = 0, valor2;

        /// <summary>
        /// Diz se a operação foi pressionada ou não
        /// </summary>
        bool operacaoPressionada = false;

        /// <summary>
        /// Escreve os números no ecrã
        /// </summary>
        /// <param name="numero"></param>
        private void AdicionarNumero(string numero)
        {
            if ((textBox1.Text == "0") || operacaoPressionada)
                textBox1.Clear();
            operacaoPressionada = false;
            textBox1.Text += numero;
        }

        /// <summary>
        /// Define a operação
        /// </summary>
        private void SetOperacao(char op)
        {
            valor1 = Double.Parse(textBox1.Text);
            operacao = op;
            operacaoPressionada = true;
        }
        public Form1()
        {
            InitializeComponent();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
            textBox1.Text = "0";  // Inicializa o TextBox com 0
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BotaoC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            valor1 = 0;
            valor2 = 0;
            operacao = '\0';  // Reseta a operação
            textBox1.Text = "0"; // Reseta o display para 0
        }
        private void BotaoOperacao_Click(object sender, EventArgs e)
        {
            
            valor1 = Double.Parse(textBox1.Text);  // Armazena o primeiro valor
            Button botao = (Button)sender;
            operacao = Convert.ToChar(botao.Text);  // Armazena a operação
            operacaoPressionada = true;
        }
        private void BotaoNumero_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || operacaoPressionada)
                textBox1.Clear();
            operacaoPressionada = false;
            Button botao = (Button)sender;
            textBox1.Text += botao.Text;
        }
        private void BotaoZero_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("0");
        }
        private void BotaoUm_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("1");
        }
        private void BotaoDois_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("2");
        }
        private void BotaoTres_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("3");
        }
        private void BotaoQuatro_Click(object sender, EventArgs e)
        {
            if (contar >=2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("4");
        }
        private void BotaoCinco_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("5");
        }
        private void BotaoSeis_Click(object sender, EventArgs e)
        {
            if (contar >= 0)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("6");
        }
        private void BotaoSete_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("7");
        }

        private void BotaoOito_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("8");
        }

        private void BotaoNove_Click(object sender, EventArgs e)
        {
            if (contar >= 2)
            {
                textBox1.Text = "0";
                valor1 = 0;
                valor2 = 0;
                AdicionarNumero("0");
            }
            AdicionarNumero("9");
        }
        private void BotaoVirgula_Click(object sender, EventArgs e)
        {  
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }
        private void BotaoAdicao_Click(object sender, EventArgs e)
        {
            SetOperacao('+');
        }
        private void BotaoSubtracao_Click(object sender, EventArgs e)
        {
            SetOperacao('-');
        }
        private void BotaoMultiplcacao_Click(object sender, EventArgs e)
        {
            SetOperacao('*');
        }
        private void BotaoDivisao_Click(object sender, EventArgs e)
        {
            SetOperacao('/');
        }
        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            valor2 = Double.Parse(textBox1.Text);
            switch (operacao)
            {
                case '+':
                    textBox1.Text = (valor1 + valor2).ToString();
                    break;
                case '-':
                    textBox1.Text = (valor1 - valor2).ToString();
                    break;
                case '*':
                    textBox1.Text = (valor1 * valor2).ToString();
                    break;
                case '/':
                    if (valor2 != 0)
                        textBox1.Text = (valor1 / valor2).ToString();
                    else
                        textBox1.Text = "Erro: Div/0";
                    break;
                case '^':   
                        textBox1.Text = Math.Pow(valor1, valor2).ToString(); // Calculo de potência                    
                    break;
            }
            operacaoPressionada = false;
        }
        private void BotaoPorcentagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código não implementado para este botão","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.ShowDialog();
        }
        private void BotaoFracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código não implementado para este botão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ShowDialog();
        }
        private void BotaoPotencia_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Código não implementado para este botão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.ShowDialog();
            SetOperacao('^');
            
        }
        private void BotaoRaiz_Click(object sender, EventArgs e)
        {
            contar++;
            if (double.TryParse(textBox1.Text, out valor1) && valor1 >= 0)
            {
                textBox1.Text = Math.Sqrt(valor1).ToString(); // Calcula a raiz quadrada
            }
            else
            {
                textBox1.Text = "Erro: Raiz Negativa";
            }
        }
        private void BotaoCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void BotaoMaisMenos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código não implementado para este botão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ShowDialog();
        }
        /// <summary>
        /// Apaga o último caracter da string
        /// </summary>
        private void BotaoApagar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty) { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); }
        }
      
    }
}
