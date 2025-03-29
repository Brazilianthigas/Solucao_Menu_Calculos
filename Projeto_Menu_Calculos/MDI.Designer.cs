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
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
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
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.ladoALadoHorizontalToolStripMenuItem,
            this.ladoALadoVerticalToolStripMenuItem,
            this.fecharTodasToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            this.ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            this.ladoALadoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ladoALadoHorizontalToolStripMenuItem.Text = "Lado a Lado Horizontal";
            this.ladoALadoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoHorizontalToolStripMenuItem_Click);
            // 
            // ladoALadoVerticalToolStripMenuItem
            // 
            this.ladoALadoVerticalToolStripMenuItem.Name = "ladoALadoVerticalToolStripMenuItem";
            this.ladoALadoVerticalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ladoALadoVerticalToolStripMenuItem.Text = "Lado a Lado Vertical";
            this.ladoALadoVerticalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoVerticalToolStripMenuItem_Click);
            // 
            // fecharTodasToolStripMenuItem
            // 
            this.fecharTodasToolStripMenuItem.Name = "fecharTodasToolStripMenuItem";
            this.fecharTodasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fecharTodasToolStripMenuItem.Text = "Fechar Todas";
            this.fecharTodasToolStripMenuItem.Click += new System.EventHandler(this.fecharTodasToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 284);
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
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodasToolStripMenuItem;
    }
}