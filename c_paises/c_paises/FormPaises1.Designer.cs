namespace c_paises
{
    partial class FormPaises1
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
            this.grid_Paises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Paises)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Paises
            // 
            this.grid_Paises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Paises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Paises.Location = new System.Drawing.Point(0, 0);
            this.grid_Paises.Name = "grid_Paises";
            this.grid_Paises.Size = new System.Drawing.Size(800, 450);
            this.grid_Paises.TabIndex = 0;
            // 
            // FormPaises1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_Paises);
            this.Name = "FormPaises1";
            this.Text = "FormPaises1";
            this.Load += new System.EventHandler(this.FormPaises1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Paises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Paises;
    }
}

