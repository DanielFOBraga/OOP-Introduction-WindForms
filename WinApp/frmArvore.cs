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
    public partial class frmArvore : Form
    {
        public frmArvore()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Height = 270;
            this.Width = 370;
            label_arvore.Visible = true;
            label_arvore.Text = string.Empty;
            label_arvore.TextAlign = ContentAlignment.TopCenter;
            label_arvore.Font = new Font("Microsoft Sans Serif", 14);
            //ler valor
            int n = (int)numericUpDown1.Value;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    label_arvore.Text += "*";                    
                }
                label_arvore.Text += "\r\n";
            }
            for (int i = 0; i < 2; i++)
            {
                label_arvore.Text += "||\r\n";
            }
        }

        private void FrmArvore_Load(object sender, EventArgs e)
        {
            this.Height = 178;
            this.Width = 188;
            label_arvore.Visible = false;
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            this.Height = 178;
            this.Width = 188;
            label_arvore.Visible = false;
        }
    }
}
