using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinApp
{
    public partial class frmFicheiros : Form
    {
        public struct Pessoa
        {
            string Nome;
            string Morada;
            DateTime DataNascimento;
            byte Idade()
            {
                int dias = (int)DateTime.Now.Subtract(DataNascimento).TotalDays;
                byte anos = (byte)(dias / 365.25);
                return anos;
            }
        }
        public frmFicheiros()
        {
            InitializeComponent();
        }

        private void Button_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog gravar_ficheiro = new SaveFileDialog();
            gravar_ficheiro.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (gravar_ficheiro.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter ficheiro = new
                    StreamWriter(gravar_ficheiro.FileName, false, Encoding.UTF8);
                    ficheiro.Write(textBox_Guardar.Text);
                    ficheiro.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_GuardarAppend_Click(object sender, EventArgs e)
        {
            SaveFileDialog gravar_ficheiro = new SaveFileDialog();
            gravar_ficheiro.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (gravar_ficheiro.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter ficheiro = new
                    StreamWriter(gravar_ficheiro.FileName, true, Encoding.UTF8);
                    ficheiro.Write(textBox_GuardarAppend.Text);
                    ficheiro.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TabPageLeituraFicheiro_Enter(object sender, EventArgs e)
        {
            OpenFileDialog abrir_ficheiro = new OpenFileDialog();

            try
            {
                abrir_ficheiro.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*";
                string appPath = Directory.GetParent(Directory.GetParent(
                Path.GetDirectoryName(Application.ExecutablePath)).
                ToString()).ToString();
                abrir_ficheiro.InitialDirectory = appPath;

                if (abrir_ficheiro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamReader ficheiro = new
                    StreamReader(abrir_ficheiro.FileName, Encoding.UTF8);
                    textBox_Ler.Text = ficheiro.ReadToEnd();
                    ficheiro.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
