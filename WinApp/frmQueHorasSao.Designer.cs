namespace WinApp
{
    partial class frmQueHorasSao
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
            this.components = new System.ComponentModel.Container();
            this.progress_Horas = new System.Windows.Forms.ProgressBar();
            this.label_hora = new System.Windows.Forms.Label();
            this.progress_Minutos = new System.Windows.Forms.ProgressBar();
            this.progress_Segundos = new System.Windows.Forms.ProgressBar();
            this.label_minutos = new System.Windows.Forms.Label();
            this.label_segundos = new System.Windows.Forms.Label();
            this.radioButton_Automatico = new System.Windows.Forms.RadioButton();
            this.radioButton_manual = new System.Windows.Forms.RadioButton();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progress_Horas
            // 
            this.progress_Horas.Location = new System.Drawing.Point(28, 29);
            this.progress_Horas.Name = "progress_Horas";
            this.progress_Horas.Size = new System.Drawing.Size(240, 23);
            this.progress_Horas.TabIndex = 0;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Location = new System.Drawing.Point(299, 29);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(56, 13);
            this.label_hora.TabIndex = 1;
            this.label_hora.Text = "label_hora";
            // 
            // progress_Minutos
            // 
            this.progress_Minutos.Location = new System.Drawing.Point(28, 79);
            this.progress_Minutos.Name = "progress_Minutos";
            this.progress_Minutos.Size = new System.Drawing.Size(600, 23);
            this.progress_Minutos.TabIndex = 2;
            // 
            // progress_Segundos
            // 
            this.progress_Segundos.Location = new System.Drawing.Point(28, 129);
            this.progress_Segundos.Name = "progress_Segundos";
            this.progress_Segundos.Size = new System.Drawing.Size(600, 23);
            this.progress_Segundos.TabIndex = 3;
            // 
            // label_minutos
            // 
            this.label_minutos.AutoSize = true;
            this.label_minutos.Location = new System.Drawing.Point(641, 79);
            this.label_minutos.Name = "label_minutos";
            this.label_minutos.Size = new System.Drawing.Size(71, 13);
            this.label_minutos.TabIndex = 4;
            this.label_minutos.Text = "label_minutos";
            // 
            // label_segundos
            // 
            this.label_segundos.AutoSize = true;
            this.label_segundos.Location = new System.Drawing.Point(641, 129);
            this.label_segundos.Name = "label_segundos";
            this.label_segundos.Size = new System.Drawing.Size(81, 13);
            this.label_segundos.TabIndex = 5;
            this.label_segundos.Text = "label_segundos";
            // 
            // radioButton_Automatico
            // 
            this.radioButton_Automatico.AutoSize = true;
            this.radioButton_Automatico.Checked = true;
            this.radioButton_Automatico.Location = new System.Drawing.Point(28, 173);
            this.radioButton_Automatico.Name = "radioButton_Automatico";
            this.radioButton_Automatico.Size = new System.Drawing.Size(78, 17);
            this.radioButton_Automatico.TabIndex = 6;
            this.radioButton_Automatico.TabStop = true;
            this.radioButton_Automatico.Text = "Automático";
            this.radioButton_Automatico.UseVisualStyleBackColor = true;
            this.radioButton_Automatico.CheckedChanged += new System.EventHandler(this.RadioButton_Automatico_CheckedChanged);
            // 
            // radioButton_manual
            // 
            this.radioButton_manual.AutoSize = true;
            this.radioButton_manual.Location = new System.Drawing.Point(28, 196);
            this.radioButton_manual.Name = "radioButton_manual";
            this.radioButton_manual.Size = new System.Drawing.Size(60, 17);
            this.radioButton_manual.TabIndex = 7;
            this.radioButton_manual.TabStop = true;
            this.radioButton_manual.Text = "Manual";
            this.radioButton_manual.UseVisualStyleBackColor = true;
            this.radioButton_manual.CheckedChanged += new System.EventHandler(this.RadioButton_manual_CheckedChanged);
            // 
            // button_atualizar
            // 
            this.button_atualizar.Location = new System.Drawing.Point(302, 189);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar.TabIndex = 8;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.Button_atualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmQueHorasSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 239);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.radioButton_manual);
            this.Controls.Add(this.radioButton_Automatico);
            this.Controls.Add(this.label_segundos);
            this.Controls.Add(this.label_minutos);
            this.Controls.Add(this.progress_Segundos);
            this.Controls.Add(this.progress_Minutos);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.progress_Horas);
            this.Name = "frmQueHorasSao";
            this.Text = "frmQueHorasSao";
            this.Load += new System.EventHandler(this.FrmQueHorasSao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_Horas;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.ProgressBar progress_Minutos;
        private System.Windows.Forms.ProgressBar progress_Segundos;
        private System.Windows.Forms.Label label_minutos;
        private System.Windows.Forms.Label label_segundos;
        private System.Windows.Forms.RadioButton radioButton_Automatico;
        private System.Windows.Forms.RadioButton radioButton_manual;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Timer timer1;
    }
}