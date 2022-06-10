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
        uscEquipe controlEquipe = null;
        uscMola controlMola = null;
        uscSuspensao controlSuspensao = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void eQ001ConsultarEquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEQ001 frmEQ001 = new frmEQ001();
            //frmEQ001.Show();
            Equipe();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CalculoMola();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CalculoSuspensao();
        }

        private void DisposeAll()
        {
            try
            {
                btnFecharTela.Visible = false;

                GC.Collect();
                if (controlEquipe != null)
                {
                    controlEquipe.Dispose();
                }
                if (controlSuspensao != null)
                {
                    controlSuspensao.Dispose();
                }
                if (controlMola != null)
                {
                    controlMola.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void Equipe()
        {
            try
            {
                DisposeAll();
                btnFecharTela.Visible = true;
                lblNomeTela.Text = "Cadastro de Equipes";
                pnlControl.Controls.Clear();

                controlEquipe = new uscEquipe
                {
                    Dock = DockStyle.Fill
                };

                pnlControl.Controls.Add(controlEquipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void CalculoMola()
        {
            try
            {
                DisposeAll();
                btnFecharTela.Visible = true;
                lblNomeTela.Text = "Cálculo da Constante Elástica da Mola";
                pnlControl.Controls.Clear();

                controlMola = new uscMola
                {
                    Dock = DockStyle.Fill
                };

                pnlControl.Controls.Add(controlMola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void CalculoSuspensao()
        {
            try
            {
                DisposeAll();
                btnFecharTela.Visible = true;
                lblNomeTela.Text = "Cálculo da Constante Angular da Suspensão";
                pnlControl.Controls.Clear();

                controlSuspensao = new uscSuspensao
                {
                    Dock = DockStyle.Fill
                };

                pnlControl.Controls.Add(controlSuspensao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            DisposeAll();
            lblNomeTela.Text = "";
            pnlControl.Controls.Clear();
        }
    }
}
