namespace WinApp
{
    partial class frmCambioDropDown
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
            this.textBox_valor_eur = new System.Windows.Forms.TextBox();
            this.button_converter = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox_Moeda = new System.Windows.Forms.GroupBox();
            this.comboBox_moeda = new System.Windows.Forms.ComboBox();
            this.groupBox_Moeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em €";
            // 
            // textBox_valor_eur
            // 
            this.textBox_valor_eur.Location = new System.Drawing.Point(16, 45);
            this.textBox_valor_eur.Name = "textBox_valor_eur";
            this.textBox_valor_eur.Size = new System.Drawing.Size(124, 20);
            this.textBox_valor_eur.TabIndex = 1;
            // 
            // button_converter
            // 
            this.button_converter.Location = new System.Drawing.Point(16, 83);
            this.button_converter.Name = "button_converter";
            this.button_converter.Size = new System.Drawing.Size(124, 23);
            this.button_converter.TabIndex = 2;
            this.button_converter.Text = "Converter";
            this.button_converter.UseVisualStyleBackColor = true;
            this.button_converter.Click += new System.EventHandler(this.Button_converter_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(16, 141);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(35, 13);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "label2";
            // 
            // groupBox_Moeda
            // 
            this.groupBox_Moeda.Controls.Add(this.comboBox_moeda);
            this.groupBox_Moeda.Location = new System.Drawing.Point(172, 13);
            this.groupBox_Moeda.Name = "groupBox_Moeda";
            this.groupBox_Moeda.Size = new System.Drawing.Size(200, 161);
            this.groupBox_Moeda.TabIndex = 4;
            this.groupBox_Moeda.TabStop = false;
            this.groupBox_Moeda.Text = "Moeda";
            // 
            // comboBox_moeda
            // 
            this.comboBox_moeda.FormattingEnabled = true;
            this.comboBox_moeda.Items.AddRange(new object[] {
            "Dollar",
            "Libra",
            "Iéne",
            "SEK"});
            this.comboBox_moeda.Location = new System.Drawing.Point(7, 20);
            this.comboBox_moeda.Name = "comboBox_moeda";
            this.comboBox_moeda.Size = new System.Drawing.Size(187, 21);
            this.comboBox_moeda.TabIndex = 0;
            // 
            // frmCambioDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 213);
            this.Controls.Add(this.groupBox_Moeda);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_converter);
            this.Controls.Add(this.textBox_valor_eur);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioDropDown";
            this.Text = "frmCambioDropDown";
            this.groupBox_Moeda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_valor_eur;
        private System.Windows.Forms.Button button_converter;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.GroupBox groupBox_Moeda;
        private System.Windows.Forms.ComboBox comboBox_moeda;
    }
}