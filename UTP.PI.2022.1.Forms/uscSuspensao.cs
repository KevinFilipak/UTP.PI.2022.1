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
    public partial class uscSuspensao : UserControl
    {
        public uscSuspensao()
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
            grdEquipe.DataSource = CalculoCurso.BuscarTodasEquipe(Program.EquipeLogada.EQUIPE);

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
            frmCC002 _frmCC002 = new frmCC002();
            _frmCC002.ShowDialog();
            CarregarGrid();
        }
    }
}
