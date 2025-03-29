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

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Organiza os formulários filhos em cascata, no caso as calculadoras
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Organiza os formulários filhos lado a lado na horizontal
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Organiza os formulários filhos lado a lado na vertical
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void fecharTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Fecha todos as Janelas abertas
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }
    }
}
