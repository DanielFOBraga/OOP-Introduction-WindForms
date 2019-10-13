namespace c_paises
{
    partial class FormPaises2
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
            this.Grid_Paises = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Paises)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Paises
            // 
            this.Grid_Paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Paises.Location = new System.Drawing.Point(12, 50);
            this.Grid_Paises.Name = "Grid_Paises";
            this.Grid_Paises.Size = new System.Drawing.Size(776, 388);
            this.Grid_Paises.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nome a pesquisar:";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(109, 18);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(322, 20);
            this.textBox_Nome.TabIndex = 2;
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.Location = new System.Drawing.Point(456, 18);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(106, 23);
            this.button_Pesquisar.TabIndex = 3;
            this.button_Pesquisar.Text = "Pesquisar";
            this.button_Pesquisar.UseVisualStyleBackColor = true;
            this.button_Pesquisar.Click += new System.EventHandler(this.button_Pesquisar_Click);
            // 
            // FormPaises2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Pesquisar);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Paises);
            this.Name = "FormPaises2";
            this.Text = "FormPaises2";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Paises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Paises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_Pesquisar;
    }
}