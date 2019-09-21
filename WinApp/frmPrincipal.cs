using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //questionar o utlizador sobre a opção de terminar a aplicação
            if (MessageBox.Show("Sair da aplicação?",
                "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CumprmentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCumprimentos cumprimentos = new frmCumprimentos();
            cumprimentos.MdiParent = this;
            cumprimentos.Show();
        }

        private void FahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFahrenheit fahrenheit = new frmFahrenheit();
            fahrenheit.MdiParent = this;
            fahrenheit.Show();
        }

        private void CalcularNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaFinal notaFinal = new frmNotaFinal();
            notaFinal.MdiParent = this;
            notaFinal.Show();
        }

        private void CascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void NomeEEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomeEmail NomeEmail = new frmNomeEmail();
            NomeEmail.MdiParent = this;
            NomeEmail.Show();
        }

        private void HorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueHorasSao queHorasSao = new frmQueHorasSao();
            queHorasSao.MdiParent = this;
            queHorasSao.Show();
        }

        private void QuantoTempoPassouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantoTempoPassou quantoTempoPassou = new frmQuantoTempoPassou();
            quantoTempoPassou.MdiParent = this;
            quantoTempoPassou.Show();
        }

        private void CâmbioMoedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ComRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioRadioButton cambioRadioButton = new frmCambioRadioButton();
            cambioRadioButton.MdiParent = this;
            cambioRadioButton.Show();
        }

        private void ComCeckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioCheckBox cambioCheckBox = new frmCambioCheckBox();
            cambioCheckBox.MdiParent = this;
            cambioCheckBox.Show();
        }

        private void ComDropDownMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioDropDown cambioDropDown = new frmCambioDropDown();
            cambioDropDown.MdiParent = this;
            cambioDropDown.Show();
        }

        private void TabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.MdiParent = this;
            tabuada.Show();
        }

        private void DesenharArvoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArvore arvore = new frmArvore();
            arvore.MdiParent = this;
            arvore.Show();
        }

        private void LimparFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLimpaTexto limpaTexto = new frmLimpaTexto();
            limpaTexto.MdiParent = this;
            limpaTexto.Show();
        }

        private void HobbiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHobbies hobbies = new frmHobbies();
            hobbies.MdiParent = this;
            hobbies.Show();
        }

        private void MeusHobbiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeusHobbies meus = new frmMeusHobbies();
            meus.MdiParent = this;
            meus.Show();
        }

        private void TestFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestFuncoes testFuncoes = new frmTestFuncoes();
            testFuncoes.MdiParent = this;
            testFuncoes.Show();
        }

        private void FicheirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFicheiros ficheiros = new frmFicheiros();
            ficheiros.MdiParent = this;
            ficheiros.Show();
        }

        private void VerDadosDeBaseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerDados frmVerDados = new frmVerDados();
            frmVerDados.MdiParent = this;
            frmVerDados.Show();
        }
    }
}
