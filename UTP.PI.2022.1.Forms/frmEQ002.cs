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
        public Equipe equipe { get; set; }
        public frmEQ002()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEquipe.Text == "" || txtCOL1.Text == "" | txtPassword.Text == "" || txtNumero.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtEquipe.Text.Contains(" "))
                {
                    MessageBox.Show("O nome da Equipe não pode contar espaço!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                equipe.EQUIPE = txtEquipe.Text;
                equipe.NUMERO = txtNumero.Text;
                equipe.COL1 = txtCOL1.Text;
                equipe.COL2 = txtCOL2.Text;
                equipe.COL3 = txtCOL3.Text;
                equipe.COL4 = txtCOL4.Text;
                equipe.SENHA = txtPassword.Text;
                equipe.ADMIN = cbxAdmin.Checked;


                var message = equipe.Salvar();

                MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmEQ002_Load(object sender, EventArgs e)
        {
            try
            {
                if (equipe != null)
                {
                    button1.Text = "Atualizar Equipe";
                    txtEquipe.Text = equipe.EQUIPE;
                    txtNumero.Text = equipe.NUMERO;
                    txtCOL1.Text = equipe.COL1;
                    txtCOL2.Text = equipe.COL2;
                    txtCOL3.Text = equipe.COL3;
                    txtCOL4.Text = equipe.COL4;
                    txtPassword.Text = equipe.SENHA;
                    cbxAdmin.Checked = equipe.ADMIN;

                }
                else
                {
                    equipe = new Equipe();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
