namespace WinApp
{
    partial class frmCambioCheckBox
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
            this.label_result = new System.Windows.Forms.Label();
            this.button_converter = new System.Windows.Forms.Button();
            this.textBox_eur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_dollar = new System.Windows.Forms.CheckBox();
            this.checkBox_libra = new System.Windows.Forms.CheckBox();
            this.checkBox_iene = new System.Windows.Forms.CheckBox();
            this.checkBox_SEK = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(12, 123);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(44, 13);
            this.label_result.TabIndex = 9;
            this.label_result.Text = "X Dollar";
            // 
            // button_converter
            // 
            this.button_converter.Location = new System.Drawing.Point(12, 70);
            this.button_converter.Name = "button_converter";
            this.button_converter.Size = new System.Drawing.Size(106, 23);
            this.button_converter.TabIndex = 8;
            this.button_converter.Text = "Converter";
            this.button_converter.UseVisualStyleBackColor = true;
            this.button_converter.Click += new System.EventHandler(this.Button_converter_Click);
            // 
            // textBox_eur
            // 
            this.textBox_eur.Location = new System.Drawing.Point(12, 29);
            this.textBox_eur.Name = "textBox_eur";
            this.textBox_eur.Size = new System.Drawing.Size(106, 20);
            this.textBox_eur.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor em €";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_SEK);
            this.groupBox1.Controls.Add(this.checkBox_iene);
            this.groupBox1.Controls.Add(this.checkBox_libra);
            this.groupBox1.Controls.Add(this.checkBox_dollar);
            this.groupBox1.Location = new System.Drawing.Point(159, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // checkBox_dollar
            // 
            this.checkBox_dollar.AutoSize = true;
            this.checkBox_dollar.Location = new System.Drawing.Point(7, 20);
            this.checkBox_dollar.Name = "checkBox_dollar";
            this.checkBox_dollar.Size = new System.Drawing.Size(53, 17);
            this.checkBox_dollar.TabIndex = 0;
            this.checkBox_dollar.Text = "Dollar";
            this.checkBox_dollar.UseVisualStyleBackColor = true;
            // 
            // checkBox_libra
            // 
            this.checkBox_libra.AutoSize = true;
            this.checkBox_libra.Location = new System.Drawing.Point(6, 42);
            this.checkBox_libra.Name = "checkBox_libra";
            this.checkBox_libra.Size = new System.Drawing.Size(49, 17);
            this.checkBox_libra.TabIndex = 0;
            this.checkBox_libra.Text = "Libra";
            this.checkBox_libra.UseVisualStyleBackColor = true;
            // 
            // checkBox_iene
            // 
            this.checkBox_iene.AutoSize = true;
            this.checkBox_iene.Location = new System.Drawing.Point(6, 64);
            this.checkBox_iene.Name = "checkBox_iene";
            this.checkBox_iene.Size = new System.Drawing.Size(47, 17);
            this.checkBox_iene.TabIndex = 0;
            this.checkBox_iene.Text = "Iéne";
            this.checkBox_iene.UseVisualStyleBackColor = true;
            // 
            // checkBox_SEK
            // 
            this.checkBox_SEK.AutoSize = true;
            this.checkBox_SEK.Location = new System.Drawing.Point(6, 86);
            this.checkBox_SEK.Name = "checkBox_SEK";
            this.checkBox_SEK.Size = new System.Drawing.Size(47, 17);
            this.checkBox_SEK.TabIndex = 0;
            this.checkBox_SEK.Text = "SEK";
            this.checkBox_SEK.UseVisualStyleBackColor = true;
            // 
            // frmCambioCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 159);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_converter);
            this.Controls.Add(this.textBox_eur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCambioCheckBox";
            this.Text = "frmCambioCheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_converter;
        private System.Windows.Forms.TextBox textBox_eur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_SEK;
        private System.Windows.Forms.CheckBox checkBox_iene;
        private System.Windows.Forms.CheckBox checkBox_libra;
        private System.Windows.Forms.CheckBox checkBox_dollar;
    }
}