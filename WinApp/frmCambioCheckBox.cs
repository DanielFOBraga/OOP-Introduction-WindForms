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
    public partial class frmCambioCheckBox : Form
    {public frmCambioCheckBox ()
        {
            InitializeComponent();

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

            //converter e mostrar resultados
            label_result.Text = string.Empty;
            if (checkBox_dollar.Checked == true)
            {
                resultado = valor * dollar;
                label_result.Text += $"{resultado} $\r\n";
            }
            if (checkBox_libra.Checked == true)
            {
                resultado = valor * libra;
                label_result.Text += $"{resultado} £\r\n";
            }
            if (checkBox_iene.Checked == true)
            {
                resultado = valor * iene;
                label_result.Text += $"{resultado} ¥\r\n";
            }
            if (checkBox_SEK.Checked == true)
            {
                resultado = valor * sek;
                label_result.Text += $"{resultado} kr\r\n";
            }            
        }
    }
}
