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
        public frmCC001()
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

        private void grdEquipe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmEQ002 _frm = new frmEQ002();

                _frm.equipe = (Equipe)grdEquipe.CurrentRow.DataBoundItem;
                _frm.ShowDialog();

                CarregarGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdEquipe_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Delete)
                {

                    DialogResult dialogResult =  MessageBox.Show("Tem certeza que deseja deletar esta equipe?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (dialogResult == DialogResult.Yes)
                    {
                        var obj = (Equipe)grdEquipe.CurrentRow.DataBoundItem;
                        obj.Excluir();
                    }

                    CarregarGrid();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
