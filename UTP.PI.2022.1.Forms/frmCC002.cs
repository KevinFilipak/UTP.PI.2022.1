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
    public partial class frmCC002 : Form
    {
        public List<CalculoCurso> calculo = new List<CalculoCurso>();



        public frmCC002()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void frmEQ002_Load(object sender, EventArgs e)
        {

            calculo.Add(new CalculoCurso()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 1,

            }); ;
            calculo.Add(new CalculoCurso()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 2,

            }); ;
            calculo.Add(new CalculoCurso()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 3,

            }); ;
            calculo.Add(new CalculoCurso()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 4,

            }); ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoda1_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 01";
            MostrarCampos();

            if (calculo[0].CONSTANTE > 0)
            {
                txtDistanciaChao.Text = calculo[0].DISTANCIA_CHAO.ToString();
                txtComprimentoTriangulo.Text = calculo[0].DISTANCIA_TRIANGULO.ToString();
                lblResultado.Text = calculo[0].CONSTANTE.ToString();

            }
            else
            {
                txtDistanciaChao.Clear();
                txtComprimentoTriangulo.Clear();
                lblResultado.Text = "";
            }
        }

        private void btnRoda2_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 02";
            MostrarCampos();

            if (calculo[1].CONSTANTE > 0)
            {
                txtDistanciaChao.Text = calculo[1].DISTANCIA_CHAO.ToString();
                txtComprimentoTriangulo.Text = calculo[1].DISTANCIA_TRIANGULO.ToString();
                lblResultado.Text = calculo[1].CONSTANTE.ToString();

            }
            else
            {
                txtDistanciaChao.Clear();
                txtComprimentoTriangulo.Clear();
                lblResultado.Text = "";
            }
        }

        private void btnRoda3_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 03";
            MostrarCampos();

            if (calculo[2].CONSTANTE > 0)
            {
                txtDistanciaChao.Text = calculo[2].DISTANCIA_CHAO.ToString();
                txtComprimentoTriangulo.Text = calculo[2].DISTANCIA_TRIANGULO.ToString();
                lblResultado.Text = calculo[2].CONSTANTE.ToString();

            }
            else
            {
                txtDistanciaChao.Clear();
                txtComprimentoTriangulo.Clear();
                lblResultado.Text = "";
            }
        }

        private void btnRoda4_Click(object sender, EventArgs e)
        {
            if (calculo[3].CONSTANTE > 0)
            {
                txtDistanciaChao.Text = calculo[3].DISTANCIA_CHAO.ToString();
                txtComprimentoTriangulo.Text = calculo[3].DISTANCIA_TRIANGULO.ToString();
                lblResultado.Text = calculo[3].CONSTANTE.ToString();

            }
            else
            {
                txtDistanciaChao.Clear();
                txtComprimentoTriangulo.Clear();
                lblResultado.Text = "";
            }
            lblRoda.Text = "Calculo da Roda 04";
            MostrarCampos();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtDistanciaChao.Text != "" || txtComprimentoTriangulo.Text != "")
            {
                double _formula = ((float.Parse(txtDistanciaChao.Text)/ 2)/ float.Parse(txtComprimentoTriangulo.Text));

                _formula = Math.Atan(_formula);
                _formula = _formula * (180 / Math.PI);
                _formula = (_formula * 2);


                lblResultado.Text = _formula.ToString();

                if (lblRoda.Text == "Calculo da Roda 01")
                {
                    calculo[0] = new CalculoCurso()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 1,
                        DISTANCIA_CHAO = float.Parse(txtDistanciaChao.Text),
                        DISTANCIA_TRIANGULO = float.Parse(txtComprimentoTriangulo.Text),
                        CONSTANTE = _formula,
                    };
                }
                else if (lblRoda.Text == "Calculo da Roda 02")
                {
                    calculo[1] = new CalculoCurso()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 2,
                        DISTANCIA_CHAO = float.Parse(txtDistanciaChao.Text),
                        DISTANCIA_TRIANGULO = float.Parse(txtComprimentoTriangulo.Text),
                        CONSTANTE = _formula,
                    };
                }
                else if (lblRoda.Text == "Calculo da Roda 03")
                {
                    calculo[2] = new CalculoCurso()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 3,
                        DISTANCIA_CHAO = float.Parse(txtDistanciaChao.Text),
                        DISTANCIA_TRIANGULO = float.Parse(txtComprimentoTriangulo.Text),
                        CONSTANTE = _formula,
                    };
                }
                else if (lblRoda.Text == "Calculo da Roda 04")
                {
                    calculo[3] = new CalculoCurso()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 4,
                        DISTANCIA_CHAO = float.Parse(txtDistanciaChao.Text),
                        DISTANCIA_TRIANGULO = float.Parse(txtComprimentoTriangulo.Text),
                        CONSTANTE = _formula,
                    };
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos!");
            }

            
        }
        private void MostrarCampos()
        {
            lblResultado.Visible = true;
            lblRoda.Visible = true;
            lblPeso.Visible = true;
            lblTextoResultado.Visible = true;
            lblDistanciaEixo.Visible = true;
            txtDistanciaChao.Visible = true;
            txtComprimentoTriangulo.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(calculo[0].CONSTANTE > 0 || calculo[1].CONSTANTE > 0 || calculo[2].CONSTANTE > 0 || calculo[3].CONSTANTE > 0)
            { 
            calculo[0].Salvar();
            calculo[1].Salvar();
            calculo[2].Salvar();
            calculo[3].Salvar();

            this.Close();
            }
            else
            {
                MessageBox.Show("Favor Calcular todas as Rodas!");
            }
        }
    }
}
