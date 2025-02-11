using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace calculadora
{
    public partial class Form1 : Form

    {
        double calc = 0;
       
        // função para pegar os operadores selecionados da calculadora 
        private Operacoes OperacaoSelecionada { get; set; }


        // função para separar os operadores da calculadora 
        private enum Operacoes {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            raiz,
        }

        // função para pegar os numeros selicionados e armazernar 
        private decimal Valor { get; set; }
        private double valorR { get; set; }

        // função para pegar os valores da função (Valores),fazendo o calc e apresentando 
        private decimal resultado { get; set; }
        private double resultadoR { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void bt_zero_Click(object sender, EventArgs e)
        {
         
            text_registro.Text += "0";
            Text_visor.Text += "0";
            calc = Convert.ToDouble(text_registro.Text);

        }
        private void bt_um_Click(object sender, EventArgs e)
        {
            text_registro.Text += "1";
            Text_visor.Text += "1";
            calc = Convert.ToDouble(text_registro.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_registro.Text += "2";
            Text_visor.Text += "2";
            calc = Convert.ToDouble(text_registro.Text);
        }

        private void bt_tres_Click(object sender, EventArgs e)
        {
           
            text_registro.Text += "3";
            Text_visor.Text += "3";
            calc = Convert.ToDouble(text_registro.Text);
        }

        private void bt_quatro_Click(object sender, EventArgs e)
        {
           
            text_registro.Text += "4";
            Text_visor.Text += "4";
            calc = Convert.ToDouble(text_registro.Text);
        }

        private void bt_cinco_Click(object sender, EventArgs e)
        {
           
            text_registro.Text += "5";
            Text_visor.Text += "5";
            calc = Convert.ToDouble(text_registro.Text);
        }

        private void bt_seis_Click(object sender, EventArgs e)
        {
           
            text_registro.Text += "6";
            Text_visor.Text += "6";
            calc = Convert.ToDouble(text_registro.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            text_registro.Text += "7";
            Text_visor.Text += "7";
            calc = Convert.ToDouble(text_registro.Text);

        }

        private void bt_oito_Click(object sender, EventArgs e)
        {
            
            text_registro.Text += "8";
            Text_visor.Text += "8";
            calc = Convert.ToDouble(text_registro.Text);

        }

        private void bt_nove_Click(object sender, EventArgs e)
        {
            
            text_registro.Text += "9";
            Text_visor.Text += "9+";
            calc = Convert.ToDouble(text_registro.Text);
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (text_registro.Text == "")
            {

                text_registro.Text = "";
            }
            else
            {
                Text_visor.Text += "x";
            OperacaoSelecionada = Operacoes.Multiplicacao;
            Valor += Convert.ToDecimal(text_registro.Text);
            text_registro.Text = "";

               }


        }


        private void button16_Click(object sender, EventArgs e)
        {
            if (text_registro.Text == "")
            {

                text_registro.Text = "";
            }
            else
            {
                Text_visor.Text += "-";
            OperacaoSelecionada = Operacoes.Subtracao;
            Valor += Convert.ToDecimal(text_registro.Text);
            text_registro.Text = "";
            }

        }


        private void button19_Click(object sender, EventArgs e)

        {
            if (text_registro.Text == "")
            {

                text_registro.Text = "";
            }
            else{   
            Text_visor.Text += "+";
                OperacaoSelecionada = Operacoes.Adicao;
                Valor += Convert.ToDecimal(text_registro.Text);
                text_registro.Text = "";



            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (text_registro.Text == "")
            {

                text_registro.Text = "";
            }
            else{

                if(text_registro.Text == "0"){
                    text_registro.Text = "não aceita divisão com zero";
                }
                else { 
            OperacaoSelecionada = Operacoes.Divisao;
            Valor += Convert.ToDecimal(text_registro.Text);
            text_registro.Text = "";
                Text_visor.Text += "/";
                }

            }

        }
        private void bt_raiz_Click(object sender, EventArgs e)
            
        {
            if (text_registro.Text == "")
            {

                text_registro.Text = "";
                }
            else { 
            text_registro.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(text_registro.Text)));
            Text_visor.Text += "√";
            }

        }


        private void bt_igual_Click(object sender, EventArgs e)
        {
            if (text_registro.Text == "")
            {

                text_registro.Text = "";
            }
            else
            {
                
                switch (OperacaoSelecionada) {
                  


                case Operacoes.Subtracao:
                    resultado = Valor - Convert.ToDecimal(text_registro.Text);

                    break;

                case Operacoes.Adicao:

                    resultado = Valor + Convert.ToDecimal(text_registro.Text);

                    break;

                case Operacoes.Multiplicacao:

                    resultado = Valor * Convert.ToDecimal(text_registro.Text);

                    break;

                case Operacoes.Divisao:

                    resultado = Valor / Convert.ToDecimal(text_registro.Text);

                    break;

            }
               
            text_registro.Text += resultadoR;
            text_registro.Text = Convert.ToString(resultado);
                }
            




        }

        private void bt_clear_Click_1(object sender, EventArgs e)
        {
            foreach (Control x in Form1.ActiveForm.Controls)
            {
                if (x is TextBox) ((TextBox)x).Clear();

                Text_visor.Text ="";
                text_registro.Text = "";
                Valor = 0;
                valorR = 0;
                resultado = 0;
                resultadoR = 0;
            }



        }

        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (text_registro.Text == "")
            {

                text_registro.Text = "";
            }
            else
            {
                text_registro.Text = Convert.ToString(calc * -1);
                Text_visor.Text = Convert.ToString(calc * -1); ;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {

            calc = calc * calc;
            text_registro.Text = Convert.ToString(calc);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text_registro.Text += ",";
            Text_visor.Text += ",";
        }
    }



    }



    
