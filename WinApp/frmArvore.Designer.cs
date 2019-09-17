namespace WinApp
{
    partial class frmArvore
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
            this.button_fazArvore = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.label_arvore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button_fazArvore
            // 
            this.button_fazArvore.Location = new System.Drawing.Point(13, 53);
            this.button_fazArvore.Name = "button_fazArvore";
            this.button_fazArvore.Size = new System.Drawing.Size(120, 23);
            this.button_fazArvore.TabIndex = 1;
            this.button_fazArvore.Text = "Faz Árvore";
            this.button_fazArvore.UseVisualStyleBackColor = true;
            this.button_fazArvore.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(13, 99);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(120, 23);
            this.button_limpar.TabIndex = 2;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.Button_limpar_Click);
            // 
            // label_arvore
            // 
            this.label_arvore.AutoSize = true;
            this.label_arvore.Location = new System.Drawing.Point(201, 19);
            this.label_arvore.Name = "label_arvore";
            this.label_arvore.Size = new System.Drawing.Size(35, 13);
            this.label_arvore.TabIndex = 3;
            this.label_arvore.Text = "label1";
            // 
            // frmArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 235);
            this.Controls.Add(this.label_arvore);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_fazArvore);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "frmArvore";
            this.Text = "frmArvore";
            this.Load += new System.EventHandler(this.FrmArvore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_fazArvore;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label_arvore;
    }
}