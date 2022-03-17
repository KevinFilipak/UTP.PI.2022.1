using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTP.PI._2022._1.Model;

namespace UTP.PI._2022._1.Forms
{
    public partial class frmEQ002 : Form
    {
        public frmEQ002()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEquipe.Text == "" || txtCOL1.Text == "" | txtPassword.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var obj = new Equipe
            {
                EQUIPE = txtEquipe.Text,
                COL1 = txtCOL1.Text,
                COL2 = txtCOL2.Text,
                COL3 = txtCOL3.Text,
                COL4 = txtCOL4.Text,
                SENHA = txtPassword.Text,
            };

            if (obj.ID == 0) { 
                obj.Inserir();
                MessageBox.Show("Equipe Cadastrada!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
