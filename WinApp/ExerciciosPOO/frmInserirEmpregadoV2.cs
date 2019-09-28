using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace WinApp.ExerciciosPOO
{
    public partial class frmInserirEmpregadoV2 : Form
    {
        public frmInserirEmpregadoV2()
        {
            InitializeComponent();
        }
        List<Empregado> Empregados = new List<Empregado>();
        private void ButtonInserirEmpregado_Click(object sender, EventArgs e)
        {
            string Nome, Departamento;
            decimal Salario;
            DateTime dataNascimento;
            Nome = textBoxNome.Text;
            decimal.TryParse(textBoxSalario.Text, out Salario);
            Departamento = textBoxDepartamento.Text;
            dataNascimento = dateTimePickerDataNascimento.Value;
            Empregado emp1;
            if (Nome != string.Empty && textBoxSalario.Text != string.Empty && Departamento != string.Empty && dataNascimento != DateTime.Now)
            {
                emp1 = new Empregado(Nome, Salario, dataNascimento, Departamento);
            }
            else if (textBoxNome.Text == string.Empty && textBoxSalario.Text == string.Empty && Departamento == string.Empty && dataNascimento == DateTime.Now)
            {
                MessageBox.Show("Deve introduzir pelo menos data de nascimento ou Salário");
            }
            else if (textBoxNome.Text != string.Empty && textBoxSalario.Text != string.Empty)
            {
                emp1 = new Empregado(Nome, Salario);
            }
            else if (textBoxNome.Text!="" && dataNascimento != DateTime.Now)
            {
                emp1 = new Empregado(Nome, dataNascimento);
            }
            LimparCampos(this);
        }
        void LimparCampos(Control C)
        {
            foreach (Control item in C.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now;
                if (item.HasChildren == true)
                    LimparCampos(item);
            }
        }
        private void TabPage2_Enter(object sender, EventArgs e)
        {
            listBoxVerEmpregados.Items.Clear();
            foreach (Empregado empregado in Empregados)
            {
                listBoxVerEmpregados.Items.Add(empregado.imprimeDados());
            }
        }
    }
}
