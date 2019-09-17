namespace WinApp
{
    partial class frmCumprimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_clique = new System.Windows.Forms.Button();
            this.textBox_Cumprimento = new System.Windows.Forms.TextBox();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_limpar = new System.Windows.Forms.Button();
            this.label_cumprimentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_clique
            // 
            this.button_clique.Location = new System.Drawing.Point(295, 91);
            this.button_clique.Name = "button_clique";
            this.button_clique.Size = new System.Drawing.Size(75, 23);
            this.button_clique.TabIndex = 0;
            this.button_clique.Text = "Clique";
            this.button_clique.UseVisualStyleBackColor = true;
            this.button_clique.Click += new System.EventHandler(this.Button_clique_Click);
            // 
            // textBox_Cumprimento
            // 
            this.textBox_Cumprimento.Location = new System.Drawing.Point(101, 65);
            this.textBox_Cumprimento.Name = "textBox_Cumprimento";
            this.textBox_Cumprimento.Size = new System.Drawing.Size(165, 20);
            this.textBox_Cumprimento.TabIndex = 1;
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(101, 120);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(165, 20);
            this.textBox_Nome.TabIndex = 2;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(137, 207);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 3;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.Button_limpar_Click);
            // 
            // label_cumprimentos
            // 
            this.label_cumprimentos.AutoSize = true;
            this.label_cumprimentos.Location = new System.Drawing.Point(98, 175);
            this.label_cumprimentos.Name = "label_cumprimentos";
            this.label_cumprimentos.Size = new System.Drawing.Size(0, 13);
            this.label_cumprimentos.TabIndex = 4;
            // 
            // frmCumprimentos
            // 
            this.AcceptButton = this.button_clique;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_limpar;
            this.ClientSize = new System.Drawing.Size(421, 281);
            this.Controls.Add(this.label_cumprimentos);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.textBox_Cumprimento);
            this.Controls.Add(this.button_clique);
            this.Name = "frmCumprimentos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clique;
        private System.Windows.Forms.TextBox textBox_Cumprimento;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label_cumprimentos;
    }
}

