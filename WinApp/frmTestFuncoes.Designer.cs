namespace WinApp
{
    partial class frmTestFuncoes
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_NomeEmail = new System.Windows.Forms.Button();
            this.button_LimpaEspacos = new System.Windows.Forms.Button();
            this.button_RemoverEspeciais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(31, 30);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(487, 151);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(31, 261);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(487, 151);
            this.textBox_output.TabIndex = 0;
            // 
            // button_NomeEmail
            // 
            this.button_NomeEmail.Location = new System.Drawing.Point(31, 190);
            this.button_NomeEmail.Name = "button_NomeEmail";
            this.button_NomeEmail.Size = new System.Drawing.Size(114, 51);
            this.button_NomeEmail.TabIndex = 1;
            this.button_NomeEmail.Text = "Nome e Emails";
            this.button_NomeEmail.UseVisualStyleBackColor = true;
            this.button_NomeEmail.Click += new System.EventHandler(this.Button_NomeEmail_Click);
            // 
            // button_LimpaEspacos
            // 
            this.button_LimpaEspacos.Location = new System.Drawing.Point(197, 190);
            this.button_LimpaEspacos.Name = "button_LimpaEspacos";
            this.button_LimpaEspacos.Size = new System.Drawing.Size(142, 51);
            this.button_LimpaEspacos.TabIndex = 1;
            this.button_LimpaEspacos.Text = "Remover Espaços";
            this.button_LimpaEspacos.UseVisualStyleBackColor = true;
            this.button_LimpaEspacos.Click += new System.EventHandler(this.Button_LimpaEspacos_Click);
            // 
            // button_RemoverEspeciais
            // 
            this.button_RemoverEspeciais.Location = new System.Drawing.Point(391, 190);
            this.button_RemoverEspeciais.Name = "button_RemoverEspeciais";
            this.button_RemoverEspeciais.Size = new System.Drawing.Size(127, 51);
            this.button_RemoverEspeciais.TabIndex = 1;
            this.button_RemoverEspeciais.Text = "Retirar Caracteres Especiais";
            this.button_RemoverEspeciais.UseVisualStyleBackColor = true;
            // 
            // frmTestFuncoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.button_RemoverEspeciais);
            this.Controls.Add(this.button_LimpaEspacos);
            this.Controls.Add(this.button_NomeEmail);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Name = "frmTestFuncoes";
            this.Text = "frmTestFuncoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_NomeEmail;
        private System.Windows.Forms.Button button_LimpaEspacos;
        private System.Windows.Forms.Button button_RemoverEspeciais;
    }
}