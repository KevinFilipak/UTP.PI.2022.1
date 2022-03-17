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
    public partial class frmEQ001 : Form
    {
        public frmEQ001()
        {
            InitializeComponent();
        }

        private void frmEQ001_Load(object sender, EventArgs e)
        {

            CarregarGrid();

        }


        void CarregarGrid()
        {

            grdEquipe.DataSource = null;


           grdEquipe.DataSource = Equipe.BuscarTodas();

           grdEquipe.Show();


        }
    }
}
