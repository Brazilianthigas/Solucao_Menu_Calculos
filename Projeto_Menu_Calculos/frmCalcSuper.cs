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
        string operacao;
        decimal vNumAnt;
        bool vLimpar = false;
        public frmCalcSuper()
        {
            InitializeComponent();
        }
        
        private void f_numeros(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (vLimpar)
            {
                lblVisor.Text = "";
                vLimpar=false;
            }

            if (lblVisor.Text == "0")
            {
                lblVisor.Text = digito;
            }
            else
            {
                lblVisor.Text += digito;
            }
        }
        private void f_operacoes(object sender, EventArgs e)
        {
            operacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lblVisor.Text);
            vLimpar = true;


        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vMumAtual = decimal.Parse(lblVisor.Text);
            switch (operacao)
            {
                case "+":
                    lblVisor.Text= (vNumAnt=vNumAnt).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt = vNumAnt).ToString();
                    break;
                default:
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
