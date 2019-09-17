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
    public partial class frmQuantoTempoPassou : Form
    {
        private void CalcularDiferenca()
        {
            DateTime data1 = monthCalendar1.SelectionStart;
            DateTime data2 = monthCalendar2.SelectionStart;

            int dias = (int)data2.Subtract(data1).TotalDays;

            int meses = 0;

            while (data1.AddMonths(1) <= data2)
            {
                meses++;
                data1 = data1.AddMonths(1);
            }

            int anos = (int)(dias / 365.25);

            label_dias.Text = $"{dias} dias";
            label_meses.Text = $"{meses} meses";
            label_anos.Text = $"{anos} anos";
        }
        public frmQuantoTempoPassou()
        {
            InitializeComponent();
        }

        private void FrmQuantoTempoPassou_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxDate = DateTime.Now.AddDays(-1);
            monthCalendar2.MinDate = DateTime.Now.AddDays(1);
            CalcularDiferenca();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalcularDiferenca();
        }

        private void MonthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalcularDiferenca();
        }
    }
}
