using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validacao;

namespace maisExerciciosWindowsForms02
{
    public partial class formValidacao : Form
    {
        //initalize class
        FuncoesValidacao FunValid = new FuncoesValidacao();
        public formValidacao()
        {
            InitializeComponent();
        }

        private void FormValidacao_Load(object sender, EventArgs e)
        {
        }

        private void ButtonValidar_Click(object sender, EventArgs e)
        {            
            //validar nome
            if (FunValid.ValidarNome(textBoxNome.Text)==false)
            {
                erros.SetError(textBoxNome, "Apenas letras e espaços.");
                textBoxNome.Focus();
                textBoxNome.SelectAll();
                return;
            }
            else
            {
                erros.SetError(textBoxNome, "");
                textBoxDados.Text = textBoxNome.Text+"\r\n";
            }
            //adicionar morada
            textBoxDados.AppendText(textBoxMorada.Text + "\r\n");
            //validar codigo postal
            if (FunValid.ValidarCodigoPostal(maskedTextBoxCodigoPostal.Text)==false)
            {
                erros.SetError(maskedTextBoxCodigoPostal, "Deve introduzir um código postal válido.");
                maskedTextBoxCodigoPostal.Focus();
                maskedTextBoxCodigoPostal.SelectAll();
            }
            else
            {
                erros.SetError(maskedTextBoxCodigoPostal, "");
                textBoxDados.AppendText(maskedTextBoxCodigoPostal.Text+", ");
            }
            //adicionar localidade
            textBoxDados.AppendText(textBoxLocalidade.Text + "\r\n");
            //validar email
            if (FunValid.ValidarEmail(textBoxEmail.Text)==false)
            {
                erros.SetError(textBoxEmail, "Deve introduzir o email corretamente.");
                textBoxEmail.Focus();
                textBoxEmail.SelectAll();
            }
            else
            {
                erros.SetError(textBoxEmail, "");
                textBoxDados.AppendText(textBoxEmail.Text +"\r\n");
            }
            //validar telefone e telemovel
            if (FunValid.ValidarTelefone(textBoxTelefone.Text)==false)
            {
                erros.SetError(textBoxTelefone, "Apenas 8 números começados por 2 ou 3");
                textBoxTelefone.Focus();
                textBoxTelefone.SelectAll();
            }
            else
            {
                erros.SetError(textBoxTelefone, "");
                textBoxDados.AppendText("Telefone: " + textBoxTelefone.Text + "\r\n"); 
            }
            if (FunValid.ValidarTelemovel(textBoxTelemovel.Text)==false)
            {
                erros.SetError(textBoxTelemovel, "Deve introduzir um número de telemóvel válido");
                textBoxTelemovel.Focus();
                textBoxTelemovel.SelectAll();
            }
            else
            {
                erros.SetError(textBoxTelemovel, "");
                textBoxDados.AppendText("Telemóvel: " + textBoxTelemovel.Text + "\r\n");
            }
            //validar NIF
            if (FunValid.ValidarNIF(textBoxNIF.Text)==false)
            {
                erros.SetError(textBoxNIF, "Deve introduzir um NIF válido");
            }
            else
            {
                erros.SetError(textBoxNIF, "");
                textBoxDados.AppendText("NIF: " + textBoxNIF.Text + "\r\n");
            }
            //adicionar data de nascimento
            textBoxDados.AppendText("Nasceu a " + dateTimeDataNascimento.Text);
        }

        private void TextBoxNome_Validating(object sender, CancelEventArgs e)
        {
            if (FunValid.ValidarNome(textBoxNome.Text)==false)
            {                
                erros.SetError(textBoxNome, "Introduzir nome válido");
                e.Cancel = true;
                textBoxNome.Select(0, textBoxNome.Text.Length);
            }
            else
            {
                erros.SetError(textBoxNome, "");
                e.Cancel = false;
            }
        }
    }
}
