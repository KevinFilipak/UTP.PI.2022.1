using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTP.PI._2022._1.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void eQ001ConsultarEquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEQ001 frmEQ001 = new frmEQ001();
            frmEQ001.Show();
        }

        private void eQ002NovaEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEQ002 frmEQ002 = new frmEQ002();
            frmEQ002.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            menuAdmin.Visible = Program.EquipeLogada.ADMIN;
            menuUser.Visible = !Program.EquipeLogada.ADMIN;        
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
