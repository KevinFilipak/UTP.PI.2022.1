
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
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.equipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQ001ConsultarEquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQ002NovaEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin.SuspendLayout();
            this.menuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(800, 24);
            this.menuAdmin.TabIndex = 0;
            this.menuAdmin.Text = "menuStrip1";
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuUser
            // 
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem7});
            this.menuUser.Location = new System.Drawing.Point(0, 24);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(800, 24);
            this.menuUser.TabIndex = 1;
            this.menuUser.Text = "menuStrip1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem4.Text = "Cálculos";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem5.Text = "CA001 - ";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem6.Text = "CA002 - ";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem7.Text = "Sair";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuUser);
            this.Controls.Add(this.menuAdmin);
            this.MainMenuStrip = this.menuAdmin;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Cálculo - HAJA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem equipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQ001ConsultarEquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQ002NovaEquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}