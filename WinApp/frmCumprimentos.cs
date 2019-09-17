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
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();
        }

        private void Button_clique_Click(object sender, EventArgs e)
        {
            //definir variáveis
            string cumprimento = "", nome = "";
            //obter valores definidos nos controlos TextBox
            cumprimento = textBox_Cumprimento.Text;
            nome = textBox_Nome.Text;
            //concatenar valores e apresentar na Label
            label_cumprimentos.Text = cumprimento + " " + nome + ".";
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            //limpar os controlos
            textBox_Cumprimento.Text = "";
            textBox_Nome.Text = string.Empty;
            label_cumprimentos.Text = "";
        }
    }
}
