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
    public partial class frmCC001 : Form
    {
        public Equipe equipe { get; set; }
        public frmCC001()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void frmEQ002_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoda1_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 01";
        }

        private void btnRoda2_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 02";
        }

        private void btnRoda3_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 03";

        }

        private void btnRoda4_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 04";

        }
    }
}
