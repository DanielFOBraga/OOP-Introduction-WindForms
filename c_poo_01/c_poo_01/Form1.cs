using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_poo_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_somar_Click(object sender, EventArgs e)
        {
            this.Height = 254;
            textBox_igualdade.Visible = false;
            double vx = 0, vy = 0;
            double.TryParse(textBox_px1.Text, out vx);
            double.TryParse(textBox_py1.Text, out vy);
            Ponto p1 = new Ponto();
            p1.X = vx;
            p1.Y = vy;
            double.TryParse(textBox_px2.Text, out vx);
            double.TryParse(textBox_py2.Text, out vy);
            Ponto p2 = new Ponto(vx, vy);
            Ponto p3 = p1 + p2;
        }

        private void Button_igual_Click(object sender, EventArgs e)
        {
            this.Height =295;
            textBox_igualdade.Visible = true;
        }
    }
}
