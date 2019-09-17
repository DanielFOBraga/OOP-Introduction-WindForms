namespace WinApp
{
    partial class frmHobbies
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
            this.button_carregar_hobbies = new System.Windows.Forms.Button();
            this.button_ver_sumario = new System.Windows.Forms.Button();
            this.textBox_hobbies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_carregar_hobbies
            // 
            this.button_carregar_hobbies.Location = new System.Drawing.Point(13, 13);
            this.button_carregar_hobbies.Name = "button_carregar_hobbies";
            this.button_carregar_hobbies.Size = new System.Drawing.Size(285, 23);
            this.button_carregar_hobbies.TabIndex = 0;
            this.button_carregar_hobbies.Text = "Carrega Hobbies";
            this.button_carregar_hobbies.UseVisualStyleBackColor = true;
            this.button_carregar_hobbies.Click += new System.EventHandler(this.Button_carregar_hobbies_Click);
            // 
            // button_ver_sumario
            // 
            this.button_ver_sumario.Location = new System.Drawing.Point(13, 43);
            this.button_ver_sumario.Name = "button_ver_sumario";
            this.button_ver_sumario.Size = new System.Drawing.Size(285, 23);
            this.button_ver_sumario.TabIndex = 1;
            this.button_ver_sumario.Text = "Ver Sumário";
            this.button_ver_sumario.UseVisualStyleBackColor = true;
            this.button_ver_sumario.Click += new System.EventHandler(this.Button_ver_sumario_Click);
            // 
            // textBox_hobbies
            // 
            this.textBox_hobbies.Location = new System.Drawing.Point(13, 73);
            this.textBox_hobbies.Multiline = true;
            this.textBox_hobbies.Name = "textBox_hobbies";
            this.textBox_hobbies.Size = new System.Drawing.Size(285, 182);
            this.textBox_hobbies.TabIndex = 2;
            // 
            // frmHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 268);
            this.Controls.Add(this.textBox_hobbies);
            this.Controls.Add(this.button_ver_sumario);
            this.Controls.Add(this.button_carregar_hobbies);
            this.Name = "frmHobbies";
            this.Text = "frmHobbies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_carregar_hobbies;
        private System.Windows.Forms.Button button_ver_sumario;
        private System.Windows.Forms.TextBox textBox_hobbies;
    }
}