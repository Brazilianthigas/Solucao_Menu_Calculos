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
    public partial class MDI: Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void calcBotoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcBotoes FrmCalcBotoes = new frmCalcBotoes();
            FrmCalcBotoes.MdiParent = this; //Define o menu principal como pai, no caso o MDI
            FrmCalcBotoes.Show();
        }

        private void calcRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcRadio FrmCalcRadio = new frmCalcRadio();
            FrmCalcRadio.MdiParent = this; 
            FrmCalcRadio.Show();
        }

        private void calcSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcSuper FrmCalcSuper = new frmCalcSuper();
            FrmCalcSuper.MdiParent = this;
            FrmCalcSuper.Show();
        }
    }
}
