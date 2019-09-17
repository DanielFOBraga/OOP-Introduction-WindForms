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
    public partial class frmTestFuncoes : Form
    {
        public frmTestFuncoes()
        {
            InitializeComponent();
        }

        private void Button_NomeEmail_Click(object sender, EventArgs e)
        {
            textBox_output.Text += Util.ClassesUtil.PrimeiroUltimo(textBox_input.Text) + "\r\n";
            textBox_output.Text += Util.ClassesUtil.Email1(textBox_input.Text) + "\r\n";
            textBox_output.Text += Util.ClassesUtil.Email2(textBox_input.Text) + "\r\n";
        }

        private void Button_LimpaEspacos_Click(object sender, EventArgs e)
        {

        }
    }
}
