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

namespace CalculadoraC_
{
    public partial class Form1 : Form
    {
        public int contar = 0;
        public string x;
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
            textBox1.Text = textBox1.Text + "x";
        }

        private void BotaoSubtracao_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            contar++;
        }

        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            
        }

        private void BotaoDivisao_Click(object sender, EventArgs e)
        {
            contar++;
            textBox1.Text = textBox1.Text + "÷";
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
            contar++;
        }
        
    }
}
