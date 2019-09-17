namespace WinApp
{
    partial class frmFahrenheit
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
            this.textBox_Fahrenheit = new System.Windows.Forms.TextBox();
            this.textBox_Celsius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_novo_calculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            // 
            // textBox_Fahrenheit
            // 
            this.textBox_Fahrenheit.Location = new System.Drawing.Point(134, 31);
            this.textBox_Fahrenheit.Name = "textBox_Fahrenheit";
            this.textBox_Fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.textBox_Fahrenheit.TabIndex = 1;
            // 
            // textBox_Celsius
            // 
            this.textBox_Celsius.Location = new System.Drawing.Point(134, 106);
            this.textBox_Celsius.Name = "textBox_Celsius";
            this.textBox_Celsius.ReadOnly = true;
            this.textBox_Celsius.Size = new System.Drawing.Size(100, 20);
            this.textBox_Celsius.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(134, 66);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(100, 23);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.Button_calcular_Click);
            // 
            // button_novo_calculo
            // 
            this.button_novo_calculo.Location = new System.Drawing.Point(134, 142);
            this.button_novo_calculo.Name = "button_novo_calculo";
            this.button_novo_calculo.Size = new System.Drawing.Size(100, 23);
            this.button_novo_calculo.TabIndex = 5;
            this.button_novo_calculo.Text = "Novo cálculo";
            this.button_novo_calculo.UseVisualStyleBackColor = true;
            this.button_novo_calculo.Click += new System.EventHandler(this.Button_novo_calculo_Click);
            // 
            // frmFahrenheit
            // 
            this.AcceptButton = this.button_calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_novo_calculo;
            this.ClientSize = new System.Drawing.Size(316, 239);
            this.Controls.Add(this.button_novo_calculo);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Celsius);
            this.Controls.Add(this.textBox_Fahrenheit);
            this.Controls.Add(this.label1);
            this.Name = "frmFahrenheit";
            this.Text = "frmFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Fahrenheit;
        private System.Windows.Forms.TextBox textBox_Celsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_novo_calculo;
    }
}