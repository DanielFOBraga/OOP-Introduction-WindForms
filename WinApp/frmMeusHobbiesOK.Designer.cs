namespace WinApp
{
    partial class frmMeusHobbiesOK
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
            this.textBox_Hobbies = new System.Windows.Forms.TextBox();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Os meus hobbies são:";
            // 
            // textBox_Hobbies
            // 
            this.textBox_Hobbies.Location = new System.Drawing.Point(16, 41);
            this.textBox_Hobbies.Multiline = true;
            this.textBox_Hobbies.Name = "textBox_Hobbies";
            this.textBox_Hobbies.Size = new System.Drawing.Size(274, 161);
            this.textBox_Hobbies.TabIndex = 1;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(16, 218);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(274, 23);
            this.button_Confirmar.TabIndex = 2;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.Button_Confirmar_Click);
            // 
            // frmMeusHobbiesOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 253);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.textBox_Hobbies);
            this.Controls.Add(this.label1);
            this.Name = "frmMeusHobbiesOK";
            this.Text = "frmMeusHobbiesOK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Hobbies;
        private System.Windows.Forms.Button button_Confirmar;
    }
}