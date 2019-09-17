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
    public partial class frmLimpaTexto : Form
    {
        public frmLimpaTexto()
        {
            InitializeComponent();
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    CheckBox ch = new CheckBox();
                    ch.Checked = false;
                }
                if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    rb.Checked = false;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }

            }
        }
    }
}
