namespace WinApp
{
    partial class frmCambioRadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_SEK = new System.Windows.Forms.RadioButton();
            this.radioButton_Iene = new System.Windows.Forms.RadioButton();
            this.radioButton_Libra = new System.Windows.Forms.RadioButton();
            this.radioButton_dollar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_eur = new System.Windows.Forms.TextBox();
            this.button_converter = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_SEK);
            this.groupBox1.Controls.Add(this.radioButton_Iene);
            this.groupBox1.Controls.Add(this.radioButton_Libra);
            this.groupBox1.Controls.Add(this.radioButton_dollar);
            this.groupBox1.Location = new System.Drawing.Point(160, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // radioButton_SEK
            // 
            this.radioButton_SEK.AutoSize = true;
            this.radioButton_SEK.Location = new System.Drawing.Point(6, 89);
            this.radioButton_SEK.Name = "radioButton_SEK";
            this.radioButton_SEK.Size = new System.Drawing.Size(46, 17);
            this.radioButton_SEK.TabIndex = 3;
            this.radioButton_SEK.TabStop = true;
            this.radioButton_SEK.Text = "SEK";
            this.radioButton_SEK.UseVisualStyleBackColor = true;
            // 
            // radioButton_Iene
            // 
            this.radioButton_Iene.AutoSize = true;
            this.radioButton_Iene.Location = new System.Drawing.Point(6, 66);
            this.radioButton_Iene.Name = "radioButton_Iene";
            this.radioButton_Iene.Size = new System.Drawing.Size(46, 17);
            this.radioButton_Iene.TabIndex = 2;
            this.radioButton_Iene.TabStop = true;
            this.radioButton_Iene.Text = "Iéne";
            this.radioButton_Iene.UseVisualStyleBackColor = true;
            // 
            // radioButton_Libra
            // 
            this.radioButton_Libra.AutoSize = true;
            this.radioButton_Libra.Location = new System.Drawing.Point(6, 43);
            this.radioButton_Libra.Name = "radioButton_Libra";
            this.radioButton_Libra.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Libra.TabIndex = 1;
            this.radioButton_Libra.TabStop = true;
            this.radioButton_Libra.Text = "Libra";
            this.radioButton_Libra.UseVisualStyleBackColor = true;
            // 
            // radioButton_dollar
            // 
            this.radioButton_dollar.AutoSize = true;
            this.radioButton_dollar.Location = new System.Drawing.Point(6, 20);
            this.radioButton_dollar.Name = "radioButton_dollar";
            this.radioButton_dollar.Size = new System.Drawing.Size(52, 17);
            this.radioButton_dollar.TabIndex = 0;
            this.radioButton_dollar.TabStop = true;
            this.radioButton_dollar.Text = "Dollar";
            this.radioButton_dollar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor em €";
            // 
            // textBox_eur
            // 
            this.textBox_eur.Location = new System.Drawing.Point(13, 32);
            this.textBox_eur.Name = "textBox_eur";
            this.textBox_eur.Size = new System.Drawing.Size(106, 20);
            this.textBox_eur.TabIndex = 2;
            // 
            // button_converter
            // 
            this.button_converter.Location = new System.Drawing.Point(13, 73);
            this.button_converter.Name = "button_converter";
            this.button_converter.Size = new System.Drawing.Size(106, 23);
            this.button_converter.TabIndex = 3;
            this.button_converter.Text = "Converter";
            this.button_converter.UseVisualStyleBackColor = true;
            this.button_converter.Click += new System.EventHandler(this.Button_converter_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(13, 126);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(44, 13);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "X Dollar";
            // 
            // frmCambioRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 157);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_converter);
            this.Controls.Add(this.textBox_eur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCambioRadioButton";
            this.Text = "frmCambioRadioButton";
            this.Load += new System.EventHandler(this.FrmCambioRadioButton_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_SEK;
        private System.Windows.Forms.RadioButton radioButton_Iene;
        private System.Windows.Forms.RadioButton radioButton_Libra;
        private System.Windows.Forms.RadioButton radioButton_dollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_eur;
        private System.Windows.Forms.Button button_converter;
        private System.Windows.Forms.Label label_result;
    }
}