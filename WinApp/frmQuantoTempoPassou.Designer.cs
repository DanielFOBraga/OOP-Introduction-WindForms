namespace WinApp
{
    partial class frmQuantoTempoPassou
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label_dias = new System.Windows.Forms.Label();
            this.label_meses = new System.Windows.Forms.Label();
            this.label_anos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(289, 18);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar2_DateChanged);
            // 
            // label_dias
            // 
            this.label_dias.AutoSize = true;
            this.label_dias.Location = new System.Drawing.Point(541, 25);
            this.label_dias.Name = "label_dias";
            this.label_dias.Size = new System.Drawing.Size(36, 13);
            this.label_dias.TabIndex = 2;
            this.label_dias.Text = "X dias";
            // 
            // label_meses
            // 
            this.label_meses.AutoSize = true;
            this.label_meses.Location = new System.Drawing.Point(541, 49);
            this.label_meses.Name = "label_meses";
            this.label_meses.Size = new System.Drawing.Size(47, 13);
            this.label_meses.TabIndex = 3;
            this.label_meses.Text = "X meses";
            // 
            // label_anos
            // 
            this.label_anos.AutoSize = true;
            this.label_anos.Location = new System.Drawing.Point(541, 73);
            this.label_anos.Name = "label_anos";
            this.label_anos.Size = new System.Drawing.Size(40, 13);
            this.label_anos.TabIndex = 4;
            this.label_anos.Text = "X anos";
            // 
            // frmQuantoTempoPassou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 214);
            this.Controls.Add(this.label_anos);
            this.Controls.Add(this.label_meses);
            this.Controls.Add(this.label_dias);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "frmQuantoTempoPassou";
            this.Text = "frmQuantoTempoPassou";
            this.Load += new System.EventHandler(this.FrmQuantoTempoPassou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label_dias;
        private System.Windows.Forms.Label label_meses;
        private System.Windows.Forms.Label label_anos;
    }
}