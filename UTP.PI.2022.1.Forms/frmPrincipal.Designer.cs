
namespace UTP.PI._2022._1.Forms
{
    partial class frmPrincipal
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
            this.equipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQ001ConsultarEquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQ002NovaEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cA001ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cA002ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cálculosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equipesToolStripMenuItem
            // 
            this.equipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eQ001ConsultarEquipesToolStripMenuItem,
            this.eQ002NovaEquipeToolStripMenuItem});
            this.equipesToolStripMenuItem.Name = "equipesToolStripMenuItem";
            this.equipesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.equipesToolStripMenuItem.Text = "Equipes";
            // 
            // eQ001ConsultarEquipesToolStripMenuItem
            // 
            this.eQ001ConsultarEquipesToolStripMenuItem.Name = "eQ001ConsultarEquipesToolStripMenuItem";
            this.eQ001ConsultarEquipesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eQ001ConsultarEquipesToolStripMenuItem.Text = "EQ001 - Consultar Equipes";
            this.eQ001ConsultarEquipesToolStripMenuItem.Click += new System.EventHandler(this.eQ001ConsultarEquipesToolStripMenuItem_Click);
            // 
            // eQ002NovaEquipeToolStripMenuItem
            // 
            this.eQ002NovaEquipeToolStripMenuItem.Name = "eQ002NovaEquipeToolStripMenuItem";
            this.eQ002NovaEquipeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.eQ002NovaEquipeToolStripMenuItem.Text = "EQ002 - Nova Equipe";
            this.eQ002NovaEquipeToolStripMenuItem.Click += new System.EventHandler(this.eQ002NovaEquipeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // cálculosToolStripMenuItem
            // 
            this.cálculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cA001ToolStripMenuItem,
            this.cA002ToolStripMenuItem});
            this.cálculosToolStripMenuItem.Name = "cálculosToolStripMenuItem";
            this.cálculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cálculosToolStripMenuItem.Text = "Cálculos";
            // 
            // cA001ToolStripMenuItem
            // 
            this.cA001ToolStripMenuItem.Name = "cA001ToolStripMenuItem";
            this.cA001ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cA001ToolStripMenuItem.Text = "CA001 - ";
            // 
            // cA002ToolStripMenuItem
            // 
            this.cA002ToolStripMenuItem.Name = "cA002ToolStripMenuItem";
            this.cA002ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cA002ToolStripMenuItem.Text = "CA002 - ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Cálculo - HAJA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQ001ConsultarEquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQ002NovaEquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cálculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cA001ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cA002ToolStripMenuItem;
    }
}