namespace WinApp
{
    partial class frmMeusHobbies
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
            this.checkedListBox_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox_Hobbies
            // 
            this.checkedListBox_Hobbies.FormattingEnabled = true;
            this.checkedListBox_Hobbies.Items.AddRange(new object[] {
            "Leitura",
            "Cinema",
            "Teatro",
            "Caminhar",
            "Desenhar/pintar",
            "Cozinhar",
            "Viajar",
            "Música",
            "Fotografia",
            "Voluntariado"});
            this.checkedListBox_Hobbies.Location = new System.Drawing.Point(12, 19);
            this.checkedListBox_Hobbies.Name = "checkedListBox_Hobbies";
            this.checkedListBox_Hobbies.Size = new System.Drawing.Size(284, 169);
            this.checkedListBox_Hobbies.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(12, 205);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(284, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // frmMeusHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 253);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.checkedListBox_Hobbies);
            this.Name = "frmMeusHobbies";
            this.Text = "frmMeusHobbies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Hobbies;
        private System.Windows.Forms.Button button_OK;
    }
}