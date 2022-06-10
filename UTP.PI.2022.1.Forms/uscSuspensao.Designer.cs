namespace UTP.PI._2022._1.Forms
{
    partial class uscSuspensao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdEquipe = new System.Windows.Forms.DataGridView();
            this.RODA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISTANCIA_CHAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISTANCIA_TRIANGULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONSTANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEquipe
            // 
            this.grdEquipe.AllowUserToAddRows = false;
            this.grdEquipe.AllowUserToDeleteRows = false;
            this.grdEquipe.AllowUserToResizeColumns = false;
            this.grdEquipe.AllowUserToResizeRows = false;
            this.grdEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEquipe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdEquipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEquipe.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdEquipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RODA,
            this.DISTANCIA_CHAO,
            this.DISTANCIA_TRIANGULO,
            this.CONSTANTE,
            this.DATA});
            this.grdEquipe.Location = new System.Drawing.Point(3, 3);
            this.grdEquipe.Name = "grdEquipe";
            this.grdEquipe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEquipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEquipe.RowHeadersVisible = false;
            this.grdEquipe.RowTemplate.Height = 40;
            this.grdEquipe.RowTemplate.ReadOnly = true;
            this.grdEquipe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEquipe.Size = new System.Drawing.Size(739, 372);
            this.grdEquipe.TabIndex = 1;
            this.grdEquipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipe_CellDoubleClick);
            this.grdEquipe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEquipe_KeyDown);
            // 
            // RODA
            // 
            this.RODA.DataPropertyName = "RODA";
            this.RODA.HeaderText = "Roda";
            this.RODA.Name = "RODA";
            // 
            // DISTANCIA_CHAO
            // 
            this.DISTANCIA_CHAO.DataPropertyName = "DISTANCIA_CHAO";
            this.DISTANCIA_CHAO.HeaderText = "Distância do chão";
            this.DISTANCIA_CHAO.Name = "DISTANCIA_CHAO";
            // 
            // DISTANCIA_TRIANGULO
            // 
            this.DISTANCIA_TRIANGULO.DataPropertyName = "DISTANCIA_TRIANGULO";
            this.DISTANCIA_TRIANGULO.HeaderText = "Comprimento do Triângulo da Suspensão";
            this.DISTANCIA_TRIANGULO.Name = "DISTANCIA_TRIANGULO";
            // 
            // CONSTANTE
            // 
            this.CONSTANTE.DataPropertyName = "CONSTANTE";
            this.CONSTANTE.HeaderText = "Constante (°)";
            this.CONSTANTE.Name = "CONSTANTE";
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "Data do Cálculo";
            this.DATA.Name = "DATA";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(89)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnNovo.Image = global::UTP.PI._2022._1.Forms.Properties.Resources.pencil_2x;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(628, 380);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(114, 32);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // uscSuspensao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grdEquipe);
            this.Name = "uscSuspensao";
            this.Size = new System.Drawing.Size(745, 415);
            this.Load += new System.EventHandler(this.uscEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEquipe;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RODA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISTANCIA_CHAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISTANCIA_TRIANGULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSTANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
    }
}
