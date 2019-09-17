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
    public partial class frmCambioDropDown : Form
    {
        public frmCambioDropDown()
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
            decimal.TryParse(textBox_valor_eur.Text, out valor);
            
            // converter e mostrar resultados
            label_result.Text = string.Empty;

            if (comboBox_moeda.Text == "Dollar")
                resultado = valor * dollar;
            else if (comboBox_moeda.Text == "Libra")
                resultado = valor * libra;
            else if (comboBox_moeda.Text == "Iéne")
                resultado = valor * iene;
            else if (comboBox_moeda.Text == "SEK")
                resultado = valor * sek;
            else
            {
                MessageBox.Show("Deve seleccionar uma opção!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label_result.Text = resultado.ToString();

        }
    }
}
