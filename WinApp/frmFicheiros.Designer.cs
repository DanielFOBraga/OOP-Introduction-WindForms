namespace WinApp
{
    partial class frmFicheiros
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEscritaFicheiro = new System.Windows.Forms.TabPage();
            this.tabPageEscritaFicheiroAppend = new System.Windows.Forms.TabPage();
            this.tabPageLeituraFicheiro = new System.Windows.Forms.TabPage();
            this.textBox_Guardar = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_GuardarAppend = new System.Windows.Forms.Button();
            this.textBox_GuardarAppend = new System.Windows.Forms.TextBox();
            this.textBox_Ler = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageEscritaFicheiro.SuspendLayout();
            this.tabPageEscritaFicheiroAppend.SuspendLayout();
            this.tabPageLeituraFicheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEscritaFicheiro);
            this.tabControl1.Controls.Add(this.tabPageEscritaFicheiroAppend);
            this.tabControl1.Controls.Add(this.tabPageLeituraFicheiro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEscritaFicheiro
            // 
            this.tabPageEscritaFicheiro.Controls.Add(this.button_Guardar);
            this.tabPageEscritaFicheiro.Controls.Add(this.textBox_Guardar);
            this.tabPageEscritaFicheiro.Location = new System.Drawing.Point(4, 22);
            this.tabPageEscritaFicheiro.Name = "tabPageEscritaFicheiro";
            this.tabPageEscritaFicheiro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEscritaFicheiro.Size = new System.Drawing.Size(683, 400);
            this.tabPageEscritaFicheiro.TabIndex = 0;
            this.tabPageEscritaFicheiro.Text = "Escrita em ficheiro";
            this.tabPageEscritaFicheiro.UseVisualStyleBackColor = true;
            // 
            // tabPageEscritaFicheiroAppend
            // 
            this.tabPageEscritaFicheiroAppend.Controls.Add(this.button_GuardarAppend);
            this.tabPageEscritaFicheiroAppend.Controls.Add(this.textBox_GuardarAppend);
            this.tabPageEscritaFicheiroAppend.Location = new System.Drawing.Point(4, 22);
            this.tabPageEscritaFicheiroAppend.Name = "tabPageEscritaFicheiroAppend";
            this.tabPageEscritaFicheiroAppend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEscritaFicheiroAppend.Size = new System.Drawing.Size(683, 400);
            this.tabPageEscritaFicheiroAppend.TabIndex = 1;
            this.tabPageEscritaFicheiroAppend.Text = "Escrita em ficheiro - Append";
            this.tabPageEscritaFicheiroAppend.UseVisualStyleBackColor = true;
            // 
            // tabPageLeituraFicheiro
            // 
            this.tabPageLeituraFicheiro.Controls.Add(this.textBox_Ler);
            this.tabPageLeituraFicheiro.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeituraFicheiro.Name = "tabPageLeituraFicheiro";
            this.tabPageLeituraFicheiro.Size = new System.Drawing.Size(683, 400);
            this.tabPageLeituraFicheiro.TabIndex = 2;
            this.tabPageLeituraFicheiro.Text = "Leitura de ficheiro";
            this.tabPageLeituraFicheiro.UseVisualStyleBackColor = true;
            this.tabPageLeituraFicheiro.Enter += new System.EventHandler(this.TabPageLeituraFicheiro_Enter);
            // 
            // textBox_Guardar
            // 
            this.textBox_Guardar.Location = new System.Drawing.Point(7, 7);
            this.textBox_Guardar.Multiline = true;
            this.textBox_Guardar.Name = "textBox_Guardar";
            this.textBox_Guardar.Size = new System.Drawing.Size(670, 344);
            this.textBox_Guardar.TabIndex = 0;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(545, 357);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(132, 36);
            this.button_Guardar.TabIndex = 1;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.Button_Guardar_Click);
            // 
            // button_GuardarAppend
            // 
            this.button_GuardarAppend.Location = new System.Drawing.Point(544, 357);
            this.button_GuardarAppend.Name = "button_GuardarAppend";
            this.button_GuardarAppend.Size = new System.Drawing.Size(132, 36);
            this.button_GuardarAppend.TabIndex = 3;
            this.button_GuardarAppend.Text = "Guardar";
            this.button_GuardarAppend.UseVisualStyleBackColor = true;
            this.button_GuardarAppend.Click += new System.EventHandler(this.Button_GuardarAppend_Click);
            // 
            // textBox_GuardarAppend
            // 
            this.textBox_GuardarAppend.Location = new System.Drawing.Point(6, 7);
            this.textBox_GuardarAppend.Multiline = true;
            this.textBox_GuardarAppend.Name = "textBox_GuardarAppend";
            this.textBox_GuardarAppend.Size = new System.Drawing.Size(670, 344);
            this.textBox_GuardarAppend.TabIndex = 2;
            // 
            // textBox_Ler
            // 
            this.textBox_Ler.Location = new System.Drawing.Point(5, 6);
            this.textBox_Ler.Multiline = true;
            this.textBox_Ler.Name = "textBox_Ler";
            this.textBox_Ler.Size = new System.Drawing.Size(670, 391);
            this.textBox_Ler.TabIndex = 3;
            // 
            // frmFicheiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFicheiros";
            this.Text = "Form 16 – Ficheiros";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEscritaFicheiro.ResumeLayout(false);
            this.tabPageEscritaFicheiro.PerformLayout();
            this.tabPageEscritaFicheiroAppend.ResumeLayout(false);
            this.tabPageEscritaFicheiroAppend.PerformLayout();
            this.tabPageLeituraFicheiro.ResumeLayout(false);
            this.tabPageLeituraFicheiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEscritaFicheiro;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_Guardar;
        private System.Windows.Forms.TabPage tabPageEscritaFicheiroAppend;
        private System.Windows.Forms.TabPage tabPageLeituraFicheiro;
        private System.Windows.Forms.Button button_GuardarAppend;
        private System.Windows.Forms.TextBox textBox_GuardarAppend;
        private System.Windows.Forms.TextBox textBox_Ler;
    }
}