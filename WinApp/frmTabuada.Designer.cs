namespace WinApp
{
    partial class frmTabuada
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_calcular = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(36, 63);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(120, 23);
            this.button_calcular.TabIndex = 1;
            this.button_calcular.Text = "Calcula";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.Button_calcular_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(36, 111);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(48, 130);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "1 x 3 = 3\r\n2 x 3 = 6\r\n1 x 3 = 3\r\n2 x 3 = 6\r\n1 x 3 = 3\r\n2 x 3 = 6\r\n1 x 3 = 3\r\n2 x " +
    "3 = 6\r\n1 x 3 = 3\r\n2 x 3 = 6";
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(36, 258);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(120, 23);
            this.button_limpar.TabIndex = 3;
            this.button_limpar.Text = "Limpa";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.Button_limpar_Click);
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 297);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "frmTabuada";
            this.Text = "frmTabuada";
            this.Load += new System.EventHandler(this.FrmTabuada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_limpar;
    }
}