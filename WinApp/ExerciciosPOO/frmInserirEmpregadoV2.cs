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
            if (dataNascimento == DateTime.Now && Departamento==string.Empty)
            {
                emp1 = new Empregado(Nome, Salario);
            }
            if (textBoxSalario.Text=="" && Departamento == string.Empty)
            {
                emp1 = new Empregado(Nome, dataNascimento);
            }
            if (textBoxSalario.Text == "" && Departamento == string.Empty && dataNascimento == DateTime.Now)
            {
                MessageBox.Show("Deve introduzir pelo menos data de nascimento ou Salário");
            }
            else
            {
                emp1 = new Empregado(Nome, Salario, dataNascimento, Departamento);
            }
            
        }
    }
}
