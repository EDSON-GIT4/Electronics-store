namespace My_Store
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            Titulo = new Label();
            BarraPesquisar = new TextBox();
            buttonPesquisa = new Button();
            ContaInativa = new Button();
            BarraMenu = new MenuStrip();
            TELA = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            fONTEToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ButtonConta = new Button();
            BarraMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Arial Black", 22.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(19, 27);
            Titulo.Margin = new Padding(10, 0, 10, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(425, 54);
            Titulo.TabIndex = 1;
            Titulo.Text = "BERG ELETRONICS";
            // 
            // BarraPesquisar
            // 
            BarraPesquisar.AccessibleDescription = "";
            BarraPesquisar.BorderStyle = BorderStyle.FixedSingle;
            BarraPesquisar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BarraPesquisar.HideSelection = false;
            BarraPesquisar.Location = new Point(457, 43);
            BarraPesquisar.MaxLength = 50;
            BarraPesquisar.Name = "BarraPesquisar";
            BarraPesquisar.Size = new Size(297, 31);
            BarraPesquisar.TabIndex = 2;
            // 
            // buttonPesquisa
            // 
            buttonPesquisa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesquisa.Location = new Point(760, 43);
            buttonPesquisa.Name = "buttonPesquisa";
            buttonPesquisa.Size = new Size(99, 31);
            buttonPesquisa.TabIndex = 3;
            buttonPesquisa.Text = "PESQUISAR";
            buttonPesquisa.UseVisualStyleBackColor = true;
            buttonPesquisa.Click += buttonPesquisa_Click;
            // 
            // ContaInativa
            // 
            ContaInativa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContaInativa.Location = new Point(1064, 38);
            ContaInativa.Name = "ContaInativa";
            ContaInativa.Size = new Size(94, 47);
            ContaInativa.TabIndex = 4;
            ContaInativa.Text = "ENTRAR";
            ContaInativa.UseVisualStyleBackColor = true;
            ContaInativa.Click += ContaInativa_Click;
            // 
            // BarraMenu
            // 
            BarraMenu.ImageScalingSize = new Size(20, 20);
            BarraMenu.Items.AddRange(new ToolStripItem[] { TELA });
            BarraMenu.Location = new Point(0, 0);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(1170, 28);
            BarraMenu.TabIndex = 5;
            BarraMenu.Text = "menuStrip1";
            BarraMenu.ItemClicked += menuStrip1_ItemClicked;
            // 
            // TELA
            // 
            TELA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, fONTEToolStripMenuItem });
            TELA.Name = "TELA";
            TELA.Size = new Size(122, 24);
            TELA.Text = "PREFERÊNCIAS";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(137, 26);
            toolStripMenuItem2.Text = "TELA";
            // 
            // fONTEToolStripMenuItem
            // 
            fONTEToolStripMenuItem.Name = "fONTEToolStripMenuItem";
            fONTEToolStripMenuItem.Size = new Size(137, 26);
            fONTEToolStripMenuItem.Text = "FONTE";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(122, 24);
            toolStripMenuItem1.Text = "PREFERÊNCIAS";
            // 
            // ButtonConta
            // 
            ButtonConta.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConta.Location = new Point(1053, 38);
            ButtonConta.Name = "ButtonConta";
            ButtonConta.Size = new Size(94, 58);
            ButtonConta.TabIndex = 6;
            ButtonConta.Text = "CONTA";
            ButtonConta.UseVisualStyleBackColor = true;
            ButtonConta.Visible = false;
            ButtonConta.Click += button1_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1170, 683);
            Controls.Add(ButtonConta);
            Controls.Add(ContaInativa);
            Controls.Add(buttonPesquisa);
            Controls.Add(BarraPesquisar);
            Controls.Add(Titulo);
            Controls.Add(BarraMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = BarraMenu;
            Name = "TelaInicial";
            Load += TelaInicial_Load;
            BarraMenu.ResumeLayout(false);
            BarraMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox BarraPesquisar;
        private Button buttonPesquisa;
        private Button ContaInativa;
        private MenuStrip BarraMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem TELA;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem fONTEToolStripMenuItem;
        private Button ButtonConta;
    }
}