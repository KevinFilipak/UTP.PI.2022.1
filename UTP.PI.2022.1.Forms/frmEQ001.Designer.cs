
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdEquipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grdEquipe.Location = new System.Drawing.Point(12, 12);
            this.grdEquipe.Name = "grdEquipe";
            this.grdEquipe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEquipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdEquipe.RowHeadersVisible = false;
            this.grdEquipe.RowTemplate.Height = 40;
            this.grdEquipe.RowTemplate.ReadOnly = true;
            this.grdEquipe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEquipe.Size = new System.Drawing.Size(1176, 574);
            this.grdEquipe.TabIndex = 0;
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