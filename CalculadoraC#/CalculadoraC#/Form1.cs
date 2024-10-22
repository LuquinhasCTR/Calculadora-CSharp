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
        public char operacao;
        double valor1 = 0, valor2 = 0;
        bool operacaoPressionada = false;
        private void AdicionarNumero(string numero)
        {
            if ((textBox1.Text == "0") || operacaoPressionada)
                textBox1.Clear();
            operacaoPressionada = false;
            textBox1.Text += numero;
        }
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
        private void BotaoUm_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void BotaoDois_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }
        private void BotaoSete_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void BotaoOito_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void BotaoNove_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void BotaoMultiplcacao_Click(object sender, EventArgs e)
        {
            SetOperacao('*');
        }

        private void BotaoSubtracao_Click(object sender, EventArgs e)
        {
            SetOperacao('-');
        }

        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            valor2 = Double.Parse(textBox1.Text);  // Captura o segundo valor

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
            }
            operacaoPressionada = false;  // Reseta a operação pressionada
        }

        private void BotaoDivisao_Click(object sender, EventArgs e)
        {
            SetOperacao('/');
        }

        private void BotaoPorcentagem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void BotaoVirgula_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
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
            SetOperacao('+');
        }

        private void BotaoZero_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void BotaoTres_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void BotaoQuatro_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void BotaoCinco_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void BotaoSeis_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void BotaoMaisMenos_Click(object sender, EventArgs e)
        {
            
        }

        private void BotaoApagar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty) { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); }
        }
      
    }
}
