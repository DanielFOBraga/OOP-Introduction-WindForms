namespace c_poo_01
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_px1 = new System.Windows.Forms.TextBox();
            this.textBox_py1 = new System.Windows.Forms.TextBox();
            this.textBox_px2 = new System.Windows.Forms.TextBox();
            this.textBox_py2 = new System.Windows.Forms.TextBox();
            this.textBox_pxr = new System.Windows.Forms.TextBox();
            this.textBox_pyr = new System.Windows.Forms.TextBox();
            this.button_somar = new System.Windows.Forms.Button();
            this.button_igual = new System.Windows.Forms.Button();
            this.textBox_igualdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ponto 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ponto 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "y";
            // 
            // textBox_px1
            // 
            this.textBox_px1.Location = new System.Drawing.Point(40, 56);
            this.textBox_px1.Name = "textBox_px1";
            this.textBox_px1.Size = new System.Drawing.Size(50, 20);
            this.textBox_px1.TabIndex = 1;
            // 
            // textBox_py1
            // 
            this.textBox_py1.Location = new System.Drawing.Point(40, 97);
            this.textBox_py1.Name = "textBox_py1";
            this.textBox_py1.Size = new System.Drawing.Size(50, 20);
            this.textBox_py1.TabIndex = 1;
            // 
            // textBox_px2
            // 
            this.textBox_px2.Location = new System.Drawing.Point(119, 56);
            this.textBox_px2.Name = "textBox_px2";
            this.textBox_px2.Size = new System.Drawing.Size(50, 20);
            this.textBox_px2.TabIndex = 1;
            // 
            // textBox_py2
            // 
            this.textBox_py2.Location = new System.Drawing.Point(119, 97);
            this.textBox_py2.Name = "textBox_py2";
            this.textBox_py2.Size = new System.Drawing.Size(50, 20);
            this.textBox_py2.TabIndex = 1;
            // 
            // textBox_pxr
            // 
            this.textBox_pxr.Location = new System.Drawing.Point(194, 56);
            this.textBox_pxr.Name = "textBox_pxr";
            this.textBox_pxr.Size = new System.Drawing.Size(50, 20);
            this.textBox_pxr.TabIndex = 1;
            // 
            // textBox_pyr
            // 
            this.textBox_pyr.Location = new System.Drawing.Point(194, 97);
            this.textBox_pyr.Name = "textBox_pyr";
            this.textBox_pyr.Size = new System.Drawing.Size(50, 20);
            this.textBox_pyr.TabIndex = 1;
            // 
            // button_somar
            // 
            this.button_somar.Location = new System.Drawing.Point(25, 152);
            this.button_somar.Name = "button_somar";
            this.button_somar.Size = new System.Drawing.Size(87, 43);
            this.button_somar.TabIndex = 2;
            this.button_somar.Text = "Somar pontos";
            this.button_somar.UseVisualStyleBackColor = true;
            this.button_somar.Click += new System.EventHandler(this.Button_somar_Click);
            // 
            // button_igual
            // 
            this.button_igual.Location = new System.Drawing.Point(157, 152);
            this.button_igual.Name = "button_igual";
            this.button_igual.Size = new System.Drawing.Size(87, 43);
            this.button_igual.TabIndex = 2;
            this.button_igual.Text = "Verificar igualdade";
            this.button_igual.UseVisualStyleBackColor = true;
            this.button_igual.Click += new System.EventHandler(this.Button_igual_Click);
            // 
            // textBox_igualdade
            // 
            this.textBox_igualdade.Location = new System.Drawing.Point(25, 223);
            this.textBox_igualdade.Name = "textBox_igualdade";
            this.textBox_igualdade.ReadOnly = true;
            this.textBox_igualdade.Size = new System.Drawing.Size(100, 20);
            this.textBox_igualdade.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 256);
            this.Controls.Add(this.textBox_igualdade);
            this.Controls.Add(this.button_igual);
            this.Controls.Add(this.button_somar);
            this.Controls.Add(this.textBox_pyr);
            this.Controls.Add(this.textBox_pxr);
            this.Controls.Add(this.textBox_py2);
            this.Controls.Add(this.textBox_px2);
            this.Controls.Add(this.textBox_py1);
            this.Controls.Add(this.textBox_px1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Overloading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_px1;
        private System.Windows.Forms.TextBox textBox_py1;
        private System.Windows.Forms.TextBox textBox_px2;
        private System.Windows.Forms.TextBox textBox_py2;
        private System.Windows.Forms.TextBox textBox_pxr;
        private System.Windows.Forms.TextBox textBox_pyr;
        private System.Windows.Forms.Button button_somar;
        private System.Windows.Forms.Button button_igual;
        private System.Windows.Forms.TextBox textBox_igualdade;
    }
}

