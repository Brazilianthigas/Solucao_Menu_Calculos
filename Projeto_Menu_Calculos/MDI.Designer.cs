namespace Projeto_Menu_Calculos
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcBotoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcSuperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem
            // 
            this.calculadorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcBotoesToolStripMenuItem,
            this.calcRadioToolStripMenuItem,
            this.calcSuperToolStripMenuItem});
            this.calculadorasToolStripMenuItem.Name = "calculadorasToolStripMenuItem";
            this.calculadorasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.calculadorasToolStripMenuItem.Text = "Calculadoras";
            // 
            // calcBotoesToolStripMenuItem
            // 
            this.calcBotoesToolStripMenuItem.Name = "calcBotoesToolStripMenuItem";
            this.calcBotoesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcBotoesToolStripMenuItem.Text = "Calc Botoes";
            this.calcBotoesToolStripMenuItem.Click += new System.EventHandler(this.calcBotoesToolStripMenuItem_Click);
            // 
            // calcRadioToolStripMenuItem
            // 
            this.calcRadioToolStripMenuItem.Name = "calcRadioToolStripMenuItem";
            this.calcRadioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcRadioToolStripMenuItem.Text = "Calc Radio";
            this.calcRadioToolStripMenuItem.Click += new System.EventHandler(this.calcRadioToolStripMenuItem_Click);
            // 
            // calcSuperToolStripMenuItem
            // 
            this.calcSuperToolStripMenuItem.Name = "calcSuperToolStripMenuItem";
            this.calcSuperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcSuperToolStripMenuItem.Text = "Calc Super";
            this.calcSuperToolStripMenuItem.Click += new System.EventHandler(this.calcSuperToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcBotoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcSuperToolStripMenuItem;
    }
}