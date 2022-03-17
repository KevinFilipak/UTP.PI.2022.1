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
    public partial class frmLogin : Form
    {
        public bool Validar { get; set; } = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _equipe = new Equipe();

            _equipe.EQUIPE = txtLogin.Text;
            _equipe.SENHA = txtSenha.Text;

            if (_equipe.ValidarLogin())
            {
                Program.EquipeLogada = _equipe;
                Validar = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
