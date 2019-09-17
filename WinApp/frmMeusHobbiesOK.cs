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
    public partial class frmMeusHobbiesOK : Form
    {
        public frmMeusHobbiesOK()
        {
            InitializeComponent();
        }
        public frmMeusHobbiesOK(List<string> Hobbies)
        {
            InitializeComponent();

            //adicionar informação à TextBox
            foreach (string h in Hobbies)
            {
                textBox_Hobbies.Text += h + "\r\n";
            }

        }

        private void Button_Confirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
