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
    public partial class frmCalcBotoes : Form
    {
        public frmCalcBotoes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            lblSinal.Text = "+";
            a = double.Parse(txtN1.Text);
            b= double.Parse(txtN2.Text);

            lblResultado.Text = (a + b).ToString();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }
    }
}
