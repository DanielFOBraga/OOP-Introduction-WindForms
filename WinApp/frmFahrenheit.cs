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
    public partial class frmFahrenheit : Form
    {
        public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void Button_calcular_Click(object sender, EventArgs e)
        {
            //definir variáveis
            double f = 0, c = 0;
            //obter valores definido em Fahrenheit
            double.TryParse(textBox_Fahrenheit.Text, out f);
            //converter para celsius
            c = (f - 32) / 1.8;
            //arredondar a duas casas decimais
            c = Math.Round(c, 2);
            //apresentar resultado
            textBox_Celsius.Text = c.ToString();
        }

        private void Button_novo_calculo_Click(object sender, EventArgs e)
        {
            //limpar controlos
            textBox_Fahrenheit.Text = string.Empty;
            textBox_Celsius.Text = string.Empty;
        }
    }
}
