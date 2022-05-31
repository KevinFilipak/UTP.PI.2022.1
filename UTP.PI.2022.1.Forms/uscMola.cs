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
    public partial class uscMola : UserControl
    {
        public uscMola()
        {
            InitializeComponent();
        }

        private void uscEquipe_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }


        void CarregarGrid()
        {

            grdEquipe.DataSource = null;
            grdEquipe.AutoGenerateColumns = false;
            grdEquipe.DataSource = CalculoMola.BuscarTodasEquipe(Program.EquipeLogada.EQUIPE);

            grdEquipe.Show();
        }

        private void grdEquipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void grdEquipe_KeyDown(object sender, KeyEventArgs e)
        {

        

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCC001 _frmCC001 = new frmCC001();
            _frmCC001.ShowDialog();
            CarregarGrid();
        }
    }
}
