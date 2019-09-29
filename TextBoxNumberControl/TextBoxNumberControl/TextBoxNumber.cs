using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxNumberControl
{
    public partial class TextBoxNumber: TextBox
    {
        public TextBoxNumber()
        {
            InitializeComponent();
        }
        [Category("Intervalo"), Description("Valor mínimo do intervalo de valores.")]
        public int Minimo { get; set; }

        [Category("Intervalo"), Description("Valor máximo do intervalo de valores.")]
        public int Maximo { get; set; }
        protected override void OnValidating(CancelEventArgs e)
        {
            int valor;
            if ((int.TryParse(this.Text, out valor)) == false)
            {
                e.Cancel = true;
                //não sei o que fazem as linhas seguintes
                this.SelectAll();
                this.Focus();
                throw new Exception("Erro - deve ser definido um número inteiro.");
            }
            else
            {
                if ((valor < Minimo) || (valor > Maximo))
                {
                    e.Cancel = true;
                    this.SelectAll();
                    this.Focus();
                    //gerar evento
                    ProcValorForaIntervalo(EventArgs.Empty);
                }
            }
        }
        public event EventHandler ValorForaIntervalo;

        protected virtual void ProcValorForaIntervalo(EventArgs e)
        {
            EventHandler handler = ValorForaIntervalo;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
