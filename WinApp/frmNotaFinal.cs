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
    public partial class frmNotaFinal : Form
    {
        public frmNotaFinal()
        {
            InitializeComponent();
        }

        private void Button_Calcular_Click(object sender, EventArgs e)
        {
            //definir variáveis
            double p1 = 0, p2 = 0, p3 = 0,
                teste1 = 0, teste2 = 0,
                trabalho1 = 0, trabalho2 = 0, trabalho_final = 0, final = 0;
            //ler valores referentes aos pesos
            p1 = WinApp.Properties.Settings.Default.peso1;
            p2 = WinApp.Properties.Settings.Default.peso2;
            p3 = WinApp.Properties.Settings.Default.peso3;

            //efetuar calculo de cada parecela
            //média dos testes
            double media_testes = 0;

            //obter valores dos testes
            double.TryParse(textBox_Teste1.Text, out teste1);
            double.TryParse(textBox_Teste2.Text, out teste2);
            media_testes = ((teste1 + teste2) / 2) * p1;

            //media dos trabalhos
            double media_trabalhos = 0;
            //obter valores dos testes
            double.TryParse(textBox_Trabalho1.Text, out trabalho1);
            double.TryParse(textBox_Trabalho2.Text, out trabalho2);
            media_trabalhos = ((trabalho1 + trabalho2) / 2) * p2;

            //trabalho final
            double.TryParse(textBox_TrabalhoFinal.Text, out trabalho_final);
            trabalho_final = trabalho_final * p3;

            //calcular média final
            final = media_testes + media_trabalhos + trabalho_final;

            //arredondar o cálculo a zero casa decimais
            final = Math.Round(final, 0);

            label_resultado.Text = $"A média final é: {final} valores.";
        }

        private void Button_Limpar_Click(object sender, EventArgs e)
        {
            //limpar conteúdo dos controlos
            textBox_Teste1.Text = "";
            textBox_Teste2.Text = "";
            textBox_Trabalho1.Text = "";
            textBox_Trabalho2.Text = "";
            textBox_TrabalhoFinal.Text = "";
            label_resultado.Text = "";
        }
    }
}
