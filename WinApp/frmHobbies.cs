using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace WinApp
{
    public partial class frmHobbies : Form
    {
        public frmHobbies()
        {
            InitializeComponent();
        }
        ArrayList Hobbies = new ArrayList();

        private void Button_carregar_hobbies_Click(object sender, EventArgs e)
        {
            string hobbie = "";
            do
            {
                hobbie = Interaction.InputBox("Qual é o hobbie?", "Hobbies", "", -1, -1);
                if (hobbie != "*")
                    Hobbies.Add(hobbie);
            } while (hobbie != "*");
        }

        private void Button_ver_sumario_Click(object sender, EventArgs e)
        {
            textBox_hobbies.Text = string.Empty;
            Dictionary<string, int> totais = new Dictionary<string, int>();

            foreach (var item in Hobbies)
            {
                //adicionar valor ao dicionário, caso ainda não exista
                if (!totais.ContainsKey(item.ToString()))
                    totais.Add(item.ToString(), 0);
                int total;
                //para elementos novos, o valor obtido é zero
                totais.TryGetValue(item.ToString(), out total);
                totais[item.ToString()] = total + 1;
            }
            foreach (var t in totais)
            {
                textBox_hobbies.Text += t.Key.ToString() + ": " +
                     t.Value.ToString() + "\r\n";
            }

        }
    }
}
