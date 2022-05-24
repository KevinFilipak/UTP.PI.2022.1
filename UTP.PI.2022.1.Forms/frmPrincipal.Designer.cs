
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.equipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQ001ConsultarEquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQ002NovaEquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.lblNomeTela = new System.Windows.Forms.Label();
            this.menuAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuAdmin.AutoSize = false;
            this.menuAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.menuAdmin.Dock = System.Windows.Forms.DockStyle.None;
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 91);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(800, 29);
            this.menuAdmin.TabIndex = 0;
            this.menuAdmin.Text = "menuStrip1";
            // 
            // equipesToolStripMenuItem
            // 
            this.equipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eQ001ConsultarEquipesToolStripMenuItem,
            this.eQ002NovaEquipeToolStripMenuItem});
            this.equipesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equipesToolStripMenuItem.Name = "equipesToolStripMenuItem";
            this.equipesToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.equipesToolStripMenuItem.Text = "Equipes";
            // 
            // eQ001ConsultarEquipesToolStripMenuItem
            // 
            this.eQ001ConsultarEquipesToolStripMenuItem.Name = "eQ001ConsultarEquipesToolStripMenuItem";
            this.eQ001ConsultarEquipesToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.eQ001ConsultarEquipesToolStripMenuItem.Text = "EQ001 - Consultar Equipes";
            this.eQ001ConsultarEquipesToolStripMenuItem.Click += new System.EventHandler(this.eQ001ConsultarEquipesToolStripMenuItem_Click);
            // 
            // eQ002NovaEquipeToolStripMenuItem
            // 
            this.eQ002NovaEquipeToolStripMenuItem.Name = "eQ002NovaEquipeToolStripMenuItem";
            this.eQ002NovaEquipeToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.eQ002NovaEquipeToolStripMenuItem.Text = "EQ002 - Nova Equipe";
            this.eQ002NovaEquipeToolStripMenuItem.Click += new System.EventHandler(this.eQ002NovaEquipeToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(230, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sistema de Cálculo - HAJA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UTP.PI._2022._1.Forms.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 89);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(765, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuUser
            // 
            this.menuUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuUser.AutoSize = false;
            this.menuUser.BackColor = System.Drawing.SystemColors.Window;
            this.menuUser.Dock = System.Windows.Forms.DockStyle.None;
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuUser.Location = new System.Drawing.Point(0, 93);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(800, 29);
            this.menuUser.TabIndex = 3;
            this.menuUser.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 25);
            this.toolStripMenuItem1.Text = "Cálculos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(435, 26);
            this.toolStripMenuItem2.Text = "CC001 - Cálculo da constante elástica da mola";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(435, 26);
            this.toolStripMenuItem3.Text = "CC002 - Cálculo da constante angular da suspensão";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(47, 25);
            this.toolStripMenuItem4.Text = "Sair";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Location = new System.Drawing.Point(6, 167);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(794, 341);
            this.pnlControl.TabIndex = 4;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFecharTela.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.ForeColor = System.Drawing.Color.White;
            this.btnFecharTela.Image = global::UTP.PI._2022._1.Forms.Properties.Resources.x_2x;
            this.btnFecharTela.Location = new System.Drawing.Point(762, 126);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(35, 35);
            this.btnFecharTela.TabIndex = 13;
            this.btnFecharTela.UseVisualStyleBackColor = false;
            this.btnFecharTela.Visible = false;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // lblNomeTela
            // 
            this.lblNomeTela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeTela.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTela.ForeColor = System.Drawing.Color.Black;
            this.lblNomeTela.Location = new System.Drawing.Point(3, 126);
            this.lblNomeTela.Name = "lblNomeTela";
            this.lblNomeTela.Size = new System.Drawing.Size(753, 34);
            this.lblNomeTela.TabIndex = 14;
            this.lblNomeTela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.lblNomeTela);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.menuUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuAdmin;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Cálculo - HAJA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem equipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQ001ConsultarEquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQ002NovaEquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.Label lblNomeTela;
    }
}