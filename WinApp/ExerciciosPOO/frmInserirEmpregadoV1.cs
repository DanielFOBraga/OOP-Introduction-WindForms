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
    public partial class frmInserirEmpregadoV1 : Form
    {
        public frmInserirEmpregadoV1()
        {
            InitializeComponent();            
        }
        List<Empregado> Empregados = new List<Empregado>();

        private void ButtonInserirEmpregado_Click(object sender, EventArgs e)
        {
            decimal Salario;
            Empregado emp1 = new Empregado();
            emp1.Nome = textBoxNome.Text;
            decimal.TryParse(textBoxSalario.Text, out Salario);
            emp1.Salario = Salario;
            emp1.Departamento = textBoxDepartamento.Text;
            emp1.dataNascimento = dateTimePickerDataNascimento.Value;
            Empregados.Add(emp1);
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
