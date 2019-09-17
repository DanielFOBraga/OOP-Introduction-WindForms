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
    public partial class frmNomeEmail : Form
    {
        private string RemoverCaracteresEspeciais(string Nome)
        {
            string N = Nome;

            Dictionary<char, char> especiais =
                new Dictionary<char, char>();

            especiais.Add('á', 'a');
            especiais.Add('à', 'a');
            especiais.Add('ã', 'a');

            especiais.Add('Á', 'A');
            especiais.Add('À', 'A');
            especiais.Add('Ã', 'A');

            especiais.Add('é', 'e');
            especiais.Add('ê', 'e');

            especiais.Add('É', 'E');
            especiais.Add('Ê', 'E');

            especiais.Add('í', 'i');
            especiais.Add('Í', 'I');

            especiais.Add('ó', 'o');
            especiais.Add('õ', 'o');

            especiais.Add('Ó', 'O');
            especiais.Add('Õ', 'O');

            especiais.Add('ú', 'u');
            especiais.Add('Ú', 'U');

            especiais.Add('ç', 'c');
            especiais.Add('Ç', 'C');

            foreach (KeyValuePair<char, char> item in especiais)
            {
                N = N.Replace(item.Key, item.Value);
            }

            return N;
        }
        public frmNomeEmail()
        {
            InitializeComponent();
        }

        private void Button_ver_Click(object sender, EventArgs e)
        {
            //aumentar altura janela e colocar os labels e butao visiveis
            this.Height = 300;
            label_email1.Visible = true;
            label_email2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            button_limpar.Visible = true;
            //ler nome
            string nome_completo = textBox_NomeCompleto.Text;
            string[] Nomes = nome_completo.Split(' ');
            string primeiro = Nomes[0][0].ToString().ToUpper() + Nomes[0].Substring(1).ToLower() + " " + Nomes[Nomes.Length - 1].ToLower();
            label_NomePrimeiroUltimo.Text = primeiro;
            string email1 = RemoverCaracteresEspeciais(Nomes[0].ToLower() + "." + Nomes[Nomes.Length - 1].ToLower() + "@xpto.pt");
            label_email1.Text = email1;
            string email2 = RemoverCaracteresEspeciais(Nomes[0][0].ToString().ToLower() + Nomes[Nomes.Length - 1].ToLower() + "@xpto.pt");
            label_email2.Text = email2;
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            this.Height = 167;
            label_email1.Visible = false;
            label_email2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            button_limpar.Visible = false;
        }

        private void FrmNomeEmail_Load(object sender, EventArgs e)
        {
            this.Height = 167;            
        }        
    }
}
