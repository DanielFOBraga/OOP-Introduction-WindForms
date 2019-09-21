namespace WinApp
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumprmentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeEEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantoTempoPassouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.câmbioMoedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comRadioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comCeckBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comDropDownMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenharArvoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hobbiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusHobbiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.exemplosToolStripMenuItem,
            this.exercíciosToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // exemplosToolStripMenuItem
            // 
            this.exemplosToolStripMenuItem.Name = "exemplosToolStripMenuItem";
            this.exemplosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.exemplosToolStripMenuItem.Text = "Exemplos";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cumprmentosToolStripMenuItem,
            this.fahrenheitToolStripMenuItem,
            this.calcularNotaToolStripMenuItem,
            this.nomeEEmailToolStripMenuItem,
            this.horasToolStripMenuItem,
            this.quantoTempoPassouToolStripMenuItem,
            this.câmbioMoedaToolStripMenuItem,
            this.tabuadaToolStripMenuItem,
            this.desenharArvoreToolStripMenuItem,
            this.limparFormToolStripMenuItem,
            this.hobbiesToolStripMenuItem,
            this.testFunçõesToolStripMenuItem,
            this.ficheirosToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // cumprmentosToolStripMenuItem
            // 
            this.cumprmentosToolStripMenuItem.Name = "cumprmentosToolStripMenuItem";
            this.cumprmentosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cumprmentosToolStripMenuItem.Text = "Cumprmentos";
            this.cumprmentosToolStripMenuItem.Click += new System.EventHandler(this.CumprmentosToolStripMenuItem_Click);
            // 
            // fahrenheitToolStripMenuItem
            // 
            this.fahrenheitToolStripMenuItem.Name = "fahrenheitToolStripMenuItem";
            this.fahrenheitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.fahrenheitToolStripMenuItem.Text = "Fahrenheit";
            this.fahrenheitToolStripMenuItem.Click += new System.EventHandler(this.FahrenheitToolStripMenuItem_Click);
            // 
            // calcularNotaToolStripMenuItem
            // 
            this.calcularNotaToolStripMenuItem.Name = "calcularNotaToolStripMenuItem";
            this.calcularNotaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calcularNotaToolStripMenuItem.Text = "Calcular nota";
            this.calcularNotaToolStripMenuItem.Click += new System.EventHandler(this.CalcularNotaToolStripMenuItem_Click);
            // 
            // nomeEEmailToolStripMenuItem
            // 
            this.nomeEEmailToolStripMenuItem.Name = "nomeEEmailToolStripMenuItem";
            this.nomeEEmailToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.nomeEEmailToolStripMenuItem.Text = "Nome e email";
            this.nomeEEmailToolStripMenuItem.Click += new System.EventHandler(this.NomeEEmailToolStripMenuItem_Click);
            // 
            // horasToolStripMenuItem
            // 
            this.horasToolStripMenuItem.Name = "horasToolStripMenuItem";
            this.horasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.horasToolStripMenuItem.Text = "Horas";
            this.horasToolStripMenuItem.Click += new System.EventHandler(this.HorasToolStripMenuItem_Click);
            // 
            // quantoTempoPassouToolStripMenuItem
            // 
            this.quantoTempoPassouToolStripMenuItem.Name = "quantoTempoPassouToolStripMenuItem";
            this.quantoTempoPassouToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.quantoTempoPassouToolStripMenuItem.Text = "Quanto tempo passou?";
            this.quantoTempoPassouToolStripMenuItem.Click += new System.EventHandler(this.QuantoTempoPassouToolStripMenuItem_Click);
            // 
            // câmbioMoedaToolStripMenuItem
            // 
            this.câmbioMoedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comRadioButtonToolStripMenuItem,
            this.comCeckBoxToolStripMenuItem,
            this.comDropDownMenuToolStripMenuItem});
            this.câmbioMoedaToolStripMenuItem.Name = "câmbioMoedaToolStripMenuItem";
            this.câmbioMoedaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.câmbioMoedaToolStripMenuItem.Text = "Câmbio Moeda";
            this.câmbioMoedaToolStripMenuItem.Click += new System.EventHandler(this.CâmbioMoedaToolStripMenuItem_Click);
            // 
            // comRadioButtonToolStripMenuItem
            // 
            this.comRadioButtonToolStripMenuItem.Name = "comRadioButtonToolStripMenuItem";
            this.comRadioButtonToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comRadioButtonToolStripMenuItem.Text = "Com Radio Button";
            this.comRadioButtonToolStripMenuItem.Click += new System.EventHandler(this.ComRadioButtonToolStripMenuItem_Click);
            // 
            // comCeckBoxToolStripMenuItem
            // 
            this.comCeckBoxToolStripMenuItem.Name = "comCeckBoxToolStripMenuItem";
            this.comCeckBoxToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comCeckBoxToolStripMenuItem.Text = "Com CeckBox";
            this.comCeckBoxToolStripMenuItem.Click += new System.EventHandler(this.ComCeckBoxToolStripMenuItem_Click);
            // 
            // comDropDownMenuToolStripMenuItem
            // 
            this.comDropDownMenuToolStripMenuItem.Name = "comDropDownMenuToolStripMenuItem";
            this.comDropDownMenuToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comDropDownMenuToolStripMenuItem.Text = "Com DropDown Menu";
            this.comDropDownMenuToolStripMenuItem.Click += new System.EventHandler(this.ComDropDownMenuToolStripMenuItem_Click);
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.TabuadaToolStripMenuItem_Click);
            // 
            // desenharArvoreToolStripMenuItem
            // 
            this.desenharArvoreToolStripMenuItem.Name = "desenharArvoreToolStripMenuItem";
            this.desenharArvoreToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.desenharArvoreToolStripMenuItem.Text = "Desenhar Arvore";
            this.desenharArvoreToolStripMenuItem.Click += new System.EventHandler(this.DesenharArvoreToolStripMenuItem_Click);
            // 
            // limparFormToolStripMenuItem
            // 
            this.limparFormToolStripMenuItem.Name = "limparFormToolStripMenuItem";
            this.limparFormToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.limparFormToolStripMenuItem.Text = "Limpar form";
            this.limparFormToolStripMenuItem.Click += new System.EventHandler(this.LimparFormToolStripMenuItem_Click);
            // 
            // hobbiesToolStripMenuItem
            // 
            this.hobbiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusHobbiesToolStripMenuItem});
            this.hobbiesToolStripMenuItem.Name = "hobbiesToolStripMenuItem";
            this.hobbiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.hobbiesToolStripMenuItem.Text = "Hobbies";
            this.hobbiesToolStripMenuItem.Click += new System.EventHandler(this.HobbiesToolStripMenuItem_Click);
            // 
            // meusHobbiesToolStripMenuItem
            // 
            this.meusHobbiesToolStripMenuItem.Name = "meusHobbiesToolStripMenuItem";
            this.meusHobbiesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.meusHobbiesToolStripMenuItem.Text = "Meus Hobbies";
            this.meusHobbiesToolStripMenuItem.Click += new System.EventHandler(this.MeusHobbiesToolStripMenuItem_Click);
            // 
            // testFunçõesToolStripMenuItem
            // 
            this.testFunçõesToolStripMenuItem.Name = "testFunçõesToolStripMenuItem";
            this.testFunçõesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.testFunçõesToolStripMenuItem.Text = "Test Funções";
            this.testFunçõesToolStripMenuItem.Click += new System.EventHandler(this.TestFunçõesToolStripMenuItem_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.CascataToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.VerticalToolStripMenuItem_Click);
            // 
            // ficheirosToolStripMenuItem
            // 
            this.ficheirosToolStripMenuItem.Name = "ficheirosToolStripMenuItem";
            this.ficheirosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ficheirosToolStripMenuItem.Text = "Ficheiros";
            this.ficheirosToolStripMenuItem.Click += new System.EventHandler(this.FicheirosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumprmentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrenheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeEEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantoTempoPassouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem câmbioMoedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comRadioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comCeckBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comDropDownMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenharArvoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hobbiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusHobbiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheirosToolStripMenuItem;
    }
}