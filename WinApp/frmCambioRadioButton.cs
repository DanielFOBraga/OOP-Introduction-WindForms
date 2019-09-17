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
    public partial class frmCambioRadioButton : Form
    {
        public frmCambioRadioButton()
        {
            InitializeComponent();
        }

        private void FrmCambioRadioButton_Load(object sender, EventArgs e)
        {
            label_result.Text = "";
        }

        private void Button_converter_Click(object sender, EventArgs e)
        {
            //definir variáveis
            decimal valor = 0, resultado = 0,
                dollar = Properties.Settings.Default.Dollar,
                libra = Properties.Settings.Default.Libra,
                iene = Properties.Settings.Default.Iene,
                sek = Properties.Settings.Default.SEK;

            //ler valor
            decimal.TryParse(textBox_eur.Text, out valor);

            //converter e mostrar resultado
            if (radioButton_dollar.Checked == true)
            {
                resultado = valor * dollar;
                label_result.Text = $"{resultado} $";
            }
            else if (radioButton_Libra.Checked == true)
            {
                resultado = valor * libra;
                label_result.Text = $"{resultado} £";
            }
            else if (radioButton_Iene.Checked == true)
            {
                resultado = valor * iene;
                label_result.Text = $"{resultado} ¥";
            }
            else if (radioButton_SEK.Checked == true)
            {
                resultado = valor * sek;
                label_result.Text = $"{resultado} kr";
            }
            else
            {
                MessageBox.Show("Erro", "Deve selecionar uma opção");
            }
        }
    }
}
