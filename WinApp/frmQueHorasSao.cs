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
    public partial class frmQueHorasSao : Form
    {
        private void Actualizar()
        {
            int horas = 0, minutos = 0, segundos = 0;

            horas = DateTime.Now.Hour;

            progress_Horas.Value = (horas * 100) / 24;
            label_hora.Text = $"{horas} horas";

            minutos = DateTime.Now.Minute;

            progress_Minutos.Value = (minutos * 100) / 60;
            label_minutos.Text = $"{minutos} minutos";

            segundos = DateTime.Now.Second;

            progress_Segundos.Value = (segundos * 100) / 60;
            label_segundos.Text = $"{segundos} segundos";

        }
        public frmQueHorasSao()
        {
            InitializeComponent();
        }

        private void Button_atualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmQueHorasSao_Load(object sender, EventArgs e)
        {
            Actualizar();
            //desactivar button_Actualizar
            button_atualizar.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void RadioButton_Automatico_CheckedChanged(object sender, EventArgs e)
        {
            //ativar 
            button_atualizar.Enabled = false;

            //activar relogio
            timer1.Enabled = true;
        }

        private void RadioButton_manual_CheckedChanged(object sender, EventArgs e)
        {
            //desactivar 
            button_atualizar.Enabled = true;

            //desactivar relogio
            timer1.Enabled = false;
        }
    }
}
