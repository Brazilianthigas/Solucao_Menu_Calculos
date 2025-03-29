using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Menu_Calculos
{
    public partial class frmCalcSuper : Form
    {
        double numero1 = 0, numero2 = 0, resultado = 0;
        string operacao = "";
        bool novoNumero = false;
        bool calculado = false;

        public frmCalcSuper()
        {
            InitializeComponent();
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!string.IsNullOrEmpty(operacao) && !novoNumero)
            {
                AtualizarPrevia();
            }

            numero1 = double.Parse(lblVisor.Text, System.Globalization.CultureInfo.InvariantCulture);
            operacao = btn.Text;
            lblPrevia.Text = numero1 + " " + operacao;

            novoNumero = true;
            calculado = false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!calculado && !string.IsNullOrEmpty(operacao))
            {
                AtualizarPrevia();
                operacao = "";
                numero1 = resultado;
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(lblVisor.Text, System.Globalization.CultureInfo.InvariantCulture);
            currentValue *= -1;
            lblVisor.Text = currentValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
            lblPrevia.Text = lblVisor.Text;
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
            lblPrevia.Text = "";
            numero1 = numero2 = resultado = 0;
            operacao = "";
            novoNumero = false;
            calculado = false;
        }

        private void btnLimparEntrada_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text.Length > 1)
            {
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            }
            else
            {
                lblVisor.Text = "0";
            }
            lblPrevia.Text = lblVisor.Text;
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (novoNumero)
            {
                lblVisor.Text = btn.Text;
                lblPrevia.Text += btn.Text;
                novoNumero = false;
            }
            else
            {
                if (btn.Text == "," && !lblVisor.Text.Contains("."))
                {
                    lblVisor.Text += ".";
                }
                else if (btn.Text != ",")
                {
                    lblVisor.Text += btn.Text;
                }
                lblPrevia.Text += btn.Text;
            }
        }

        private void AtualizarPrevia()
        {
            if (!string.IsNullOrEmpty(operacao))
            {
                numero2 = double.Parse(lblVisor.Text, System.Globalization.CultureInfo.InvariantCulture);

                switch (operacao)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        break;
                    case ":":
                        if (numero2 == 0)
                        {
                            MessageBox.Show("Não é possível dividir por zero!", "Erro");
                            resultado = 0;
                            lblVisor.Text = "0";
                            lblPrevia.Text = "";
                            return;
                        }
                        resultado = numero1 / numero2;
                        break;
                    case "^":
                        resultado = Math.Pow(numero1, numero2);
                        break;
                    default:
                        return;
                }

                lblVisor.Text = resultado.ToString(System.Globalization.CultureInfo.InvariantCulture);
                lblPrevia.Text = numero1 + " " + operacao + " " + numero2 + " = " + resultado;
                calculado = true;
            }
        }
    }
}
