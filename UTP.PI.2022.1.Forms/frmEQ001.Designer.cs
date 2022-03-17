
namespace UTP.PI._2022._1.Forms
{
    partial class frmEQ001
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdEquipe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEquipe
            // 
            this.grdEquipe.AllowUserToAddRows = false;
            this.grdEquipe.AllowUserToDeleteRows = false;
            this.grdEquipe.AllowUserToResizeColumns = false;
            this.grdEquipe.AllowUserToResizeRows = false;
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
            this.grdEquipe.Location = new System.Drawing.Point(12, 12);
            this.grdEquipe.Name = "grdEquipe";
            this.grdEquipe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEquipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEquipe.RowHeadersVisible = false;
            this.grdEquipe.RowTemplate.Height = 40;
            this.grdEquipe.RowTemplate.ReadOnly = true;
            this.grdEquipe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEquipe.Size = new System.Drawing.Size(1176, 574);
            this.grdEquipe.TabIndex = 0;
            this.grdEquipe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipe_CellDoubleClick);
            this.grdEquipe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdEquipe_KeyDown);
            // 
            // frmEQ001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 598);
            this.Controls.Add(this.grdEquipe);
            this.Name = "frmEQ001";
            this.Text = "EQ001 - Consulta de Equipes";
            this.Load += new System.EventHandler(this.frmEQ001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsadsadasdas;
    }
}