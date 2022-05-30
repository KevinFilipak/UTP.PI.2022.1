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
        public List<CalculoMola> calculo = new List<CalculoMola>();



        public frmCC001()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void frmEQ002_Load(object sender, EventArgs e)
        {
            //float _peso = (float)Convert.ToDouble(txtPeso.Text);

            calculo.Add(new CalculoMola()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 1,

            }); ;
            calculo.Add(new CalculoMola()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 2,

            }); ;
            calculo.Add(new CalculoMola()
            {
                EQUIPE = Program.EquipeLogada.EQUIPE,
                RODA = 3,

            }); ;
            calculo.Add(new CalculoMola()
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
                txtPeso.Text = calculo[0].PESO_RODA.ToString();
                txtDistanciaEixo.Text = calculo[0].DISTANCIA_EIXO.ToString();
                txtDistanciaApoio.Text = calculo[0].DISTANCIA_APOIO.ToString();
                lblResultado.Text = calculo[0].CONSTANTE.ToString();

            }
            else
            {
                txtPeso.Clear();
                txtDistanciaApoio.Clear();
                txtDistanciaEixo.Clear();
                lblResultado.Text = "";
            }
        }

        private void btnRoda2_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 02";
            MostrarCampos();

            if (calculo[1].CONSTANTE > 0)
            {
                txtPeso.Text = calculo[1].PESO_RODA.ToString();
                txtDistanciaEixo.Text = calculo[1].DISTANCIA_EIXO.ToString();
                txtDistanciaApoio.Text = calculo[1].DISTANCIA_APOIO.ToString();
                lblResultado.Text = calculo[1].CONSTANTE.ToString();

            }
            else
            {
                txtPeso.Clear();
                txtDistanciaApoio.Clear();
                txtDistanciaEixo.Clear();
                lblResultado.Text = "";
            }
        }

        private void btnRoda3_Click(object sender, EventArgs e)
        {
            lblRoda.Text = "Calculo da Roda 03";
            MostrarCampos();

            if (calculo[2].CONSTANTE > 0)
            {
                txtPeso.Text = calculo[2].PESO_RODA.ToString();
                txtDistanciaEixo.Text = calculo[2].DISTANCIA_EIXO.ToString();
                txtDistanciaApoio.Text = calculo[2].DISTANCIA_APOIO.ToString();
                lblResultado.Text = calculo[2].CONSTANTE.ToString();

            }
            else
            {
                txtPeso.Clear();
                txtDistanciaApoio.Clear();
                txtDistanciaEixo.Clear();
                lblResultado.Text = "";
            }
        }

        private void btnRoda4_Click(object sender, EventArgs e)
        {
            if (calculo[3].CONSTANTE > 0)
            {
                txtPeso.Text = calculo[3].PESO_RODA.ToString();
                txtDistanciaEixo.Text = calculo[3].DISTANCIA_EIXO.ToString();
                txtDistanciaApoio.Text = calculo[3].DISTANCIA_APOIO.ToString();
                lblResultado.Text = calculo[3].CONSTANTE.ToString();


            }
            else
            {
                txtPeso.Clear();
                txtDistanciaApoio.Clear();
                txtDistanciaEixo.Clear();
                lblResultado.Text = "";
            }
            lblRoda.Text = "Calculo da Roda 04";
            MostrarCampos();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtPeso.Text != "" || txtDistanciaEixo.Text != "" || txtDistanciaApoio.Text != "")
            {
                float _formula = ((float.Parse(txtPeso.Text) * float.Parse(txtDistanciaEixo.Text)) / float.Parse(txtDistanciaApoio.Text));

                lblResultado.Text = _formula.ToString() + " N/m";

                if (lblRoda.Text == "Calculo da Roda 01")
                {
                    calculo[0] = new CalculoMola()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 1,
                        PESO_RODA = float.Parse(txtPeso.Text),
                        DISTANCIA_EIXO = float.Parse(txtDistanciaEixo.Text),
                        DISTANCIA_APOIO = float.Parse(txtDistanciaApoio.Text),
                        CONSTANTE = _formula,
                    };
                }
                else if (lblRoda.Text == "Calculo da Roda 02")
                {
                    calculo[1] = new CalculoMola()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 2,
                        PESO_RODA = float.Parse(txtPeso.Text),
                        DISTANCIA_EIXO = float.Parse(txtDistanciaEixo.Text),
                        DISTANCIA_APOIO = float.Parse(txtDistanciaApoio.Text),
                        CONSTANTE = _formula,
                    };
                }
                else if (lblRoda.Text == "Calculo da Roda 03")
                {
                    calculo[2] = new CalculoMola()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 3,
                        PESO_RODA = float.Parse(txtPeso.Text),
                        DISTANCIA_EIXO = float.Parse(txtDistanciaEixo.Text),
                        DISTANCIA_APOIO = float.Parse(txtDistanciaApoio.Text),
                        CONSTANTE = _formula,
                    };
                }
                else if (lblRoda.Text == "Calculo da Roda 04")
                {
                    calculo[3] = new CalculoMola()
                    {
                        EQUIPE = Program.EquipeLogada.EQUIPE,
                        RODA = 4,
                        PESO_RODA = float.Parse(txtPeso.Text),
                        DISTANCIA_EIXO = float.Parse(txtDistanciaEixo.Text),
                        DISTANCIA_APOIO = float.Parse(txtDistanciaApoio.Text),
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
            lblDistanciaApoio.Visible = true;
            lblDistanciaEixo.Visible = true;
            txtPeso.Visible = true;
            txtDistanciaApoio.Visible = true;
            txtDistanciaEixo.Visible = true;
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
