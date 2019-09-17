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
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void Button_calcular_Click(object sender, EventArgs e)
        {
            this.Height = 366;
            label_result.Text = string.Empty;
            //ler tabuada a calcular
            int num = (int)numericUpDown1.Value;
            //calcular tabuada
            for (int i = 1; i < 11; i++)
            {
                label_result.Text += $"{i} x {num} = {i*num}\r\n";
            }
        }

        private void FrmTabuada_Load(object sender, EventArgs e)
        {
            this.Height = 144;
            label_result.Text = string.Empty;
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            this.Height = 144;
            label_result.Text = string.Empty;
            button_limpar.Visible = false;
        }
    }
}
