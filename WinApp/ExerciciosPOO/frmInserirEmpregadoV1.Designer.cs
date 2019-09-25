namespace WinApp.ExerciciosPOO
{
    partial class frmInserirEmpregadoV1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxDepartamento = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInserirEmpregado = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxVerEmpregados = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSalario);
            this.tabPage1.Controls.Add(this.dateTimePickerDataNascimento);
            this.tabPage1.Controls.Add(this.textBoxDepartamento);
            this.tabPage1.Controls.Add(this.textBoxNome);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonInserirEmpregado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(156, 157);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(176, 20);
            this.textBoxSalario.TabIndex = 4;
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(156, 112);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(302, 20);
            this.dateTimePickerDataNascimento.TabIndex = 3;
            // 
            // textBoxDepartamento
            // 
            this.textBoxDepartamento.Location = new System.Drawing.Point(156, 64);
            this.textBoxDepartamento.Name = "textBoxDepartamento";
            this.textBoxDepartamento.Size = new System.Drawing.Size(302, 20);
            this.textBoxDepartamento.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(156, 22);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(302, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // buttonInserirEmpregado
            // 
            this.buttonInserirEmpregado.Location = new System.Drawing.Point(411, 205);
            this.buttonInserirEmpregado.Name = "buttonInserirEmpregado";
            this.buttonInserirEmpregado.Size = new System.Drawing.Size(144, 45);
            this.buttonInserirEmpregado.TabIndex = 0;
            this.buttonInserirEmpregado.Text = "Inserir Empregado";
            this.buttonInserirEmpregado.UseVisualStyleBackColor = true;
            this.buttonInserirEmpregado.Click += new System.EventHandler(this.ButtonInserirEmpregado_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxVerEmpregados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.TabPage2_Enter);
            // 
            // listBoxVerEmpregados
            // 
            this.listBoxVerEmpregados.FormattingEnabled = true;
            this.listBoxVerEmpregados.Location = new System.Drawing.Point(7, 7);
            this.listBoxVerEmpregados.Name = "listBoxVerEmpregados";
            this.listBoxVerEmpregados.Size = new System.Drawing.Size(578, 251);
            this.listBoxVerEmpregados.TabIndex = 0;
            // 
            // frmInserirEmpregadoV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 320);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmInserirEmpregadoV1";
            this.Text = "Inserir Empregado";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonInserirEmpregado;
        private System.Windows.Forms.ListBox listBoxVerEmpregados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.TextBox textBoxDepartamento;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label4;
    }
}