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
    public partial class frmMeusHobbies : Form
    {
        public frmMeusHobbies()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            List<string> Hobbies = new List<string>();

            foreach (var item in checkedListBox_Hobbies.CheckedItems)
            {
                Hobbies.Add(item.ToString());
            }

            frmMeusHobbiesOK ok = new frmMeusHobbiesOK(Hobbies);
            ok.ShowDialog();

        }
    }
}
