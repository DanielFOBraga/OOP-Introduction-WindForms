namespace WinApp
{
    partial class frmNomeEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NomeCompleto = new System.Windows.Forms.TextBox();
            this.button_ver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_NomePrimeiroUltimo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_email1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_email2 = new System.Windows.Forms.Label();
            this.button_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // textBox_NomeCompleto
            // 
            this.textBox_NomeCompleto.Location = new System.Drawing.Point(124, 46);
            this.textBox_NomeCompleto.Name = "textBox_NomeCompleto";
            this.textBox_NomeCompleto.Size = new System.Drawing.Size(344, 20);
            this.textBox_NomeCompleto.TabIndex = 1;
            // 
            // button_ver
            // 
            this.button_ver.Location = new System.Drawing.Point(196, 83);
            this.button_ver.Name = "button_ver";
            this.button_ver.Size = new System.Drawing.Size(75, 23);
            this.button_ver.TabIndex = 2;
            this.button_ver.Text = "Ver";
            this.button_ver.UseVisualStyleBackColor = true;
            this.button_ver.Click += new System.EventHandler(this.Button_ver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label_NomePrimeiroUltimo
            // 
            this.label_NomePrimeiroUltimo.AutoSize = true;
            this.label_NomePrimeiroUltimo.Location = new System.Drawing.Point(124, 132);
            this.label_NomePrimeiroUltimo.Name = "label_NomePrimeiroUltimo";
            this.label_NomePrimeiroUltimo.Size = new System.Drawing.Size(129, 13);
            this.label_NomePrimeiroUltimo.TabIndex = 4;
            this.label_NomePrimeiroUltimo.Text = "label_NomePrimeiroUltimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail 1";
            // 
            // label_email1
            // 
            this.label_email1.AutoSize = true;
            this.label_email1.Location = new System.Drawing.Point(124, 166);
            this.label_email1.Name = "label_email1";
            this.label_email1.Size = new System.Drawing.Size(65, 13);
            this.label_email1.TabIndex = 6;
            this.label_email1.Text = "label_email1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail 2";
            // 
            // label_email2
            // 
            this.label_email2.AutoSize = true;
            this.label_email2.Location = new System.Drawing.Point(124, 203);
            this.label_email2.Name = "label_email2";
            this.label_email2.Size = new System.Drawing.Size(65, 13);
            this.label_email2.TabIndex = 8;
            this.label_email2.Text = "label_email2";
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(196, 235);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 9;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.Button_limpar_Click);
            // 
            // frmNomeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 275);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.label_email2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_email1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_NomePrimeiroUltimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ver);
            this.Controls.Add(this.textBox_NomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "frmNomeEmail";
            this.Text = "frmNomeEmail";
            this.Load += new System.EventHandler(this.FrmNomeEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NomeCompleto;
        private System.Windows.Forms.Button button_ver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_NomePrimeiroUltimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_email1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_email2;
        private System.Windows.Forms.Button button_limpar;
    }
}