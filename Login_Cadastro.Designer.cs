namespace My_Store;

partial class Login_Cadastro
{
   
    private System.ComponentModel.IContainer components = null;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Cadastro));
        Titulo = new Label();
        login = new Button();
        label1 = new Label();
        pergunta1 = new Label();
        register = new Button();
        pergunta2 = new Label();
        DigiteSeuNome = new Label();
        BoxNome = new TextBox();
        SeuEmal = new Label();
        BoxEmail = new TextBox();
        SuaSenha = new Label();
        BoxSenha = new TextBox();
        TextCriarConta = new Label();
        buttonCriar = new Button();
        BoxEntar1 = new TextBox();
        SeuNomeLogin = new Label();
        label3 = new Label();
        BoxEntar2 = new TextBox();
        SuaSenhaLogin = new Label();
        label4 = new Label();
        buttonEntar = new Button();
        TextEntar = new Label();
        Voltar = new Button();
        SairLogin = new Button();
        SuspendLayout();
        // 
        // Titulo
        // 
        Titulo.AutoSize = true;
        Titulo.Font = new Font("Arial Black", 22.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Titulo.ForeColor = Color.White;
        Titulo.Location = new Point(19, 9);
        Titulo.Margin = new Padding(10, 0, 10, 0);
        Titulo.Name = "Titulo";
        Titulo.Size = new Size(438, 54);
        Titulo.TabIndex = 0;
        Titulo.Text = " BERG ELETRONICS";
        // 
        // login
        // 
        login.AutoSize = true;
        login.Location = new Point(872, 261);
        login.Name = "login";
        login.Size = new Size(344, 62);
        login.TabIndex = 1;
        login.Text = "LOGIN";
        login.UseVisualStyleBackColor = true;
        login.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.Location = new Point(58, 702);
        label1.Name = "label1";
        label1.Size = new Size(1149, 17);
        label1.TabIndex = 2;
        label1.Text = "Este software é somente para testes, é um projeto de portifólio, credenciais, imagens ou qualquer outro tipo de informação deve ser considerado acadêmico\r\n";
        label1.Click += label1_Click_1;
        // 
        // pergunta1
        // 
        pergunta1.AutoSize = true;
        pergunta1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        pergunta1.ForeColor = SystemColors.ButtonHighlight;
        pergunta1.Location = new Point(872, 220);
        pergunta1.Name = "pergunta1";
        pergunta1.Size = new Size(335, 27);
        pergunta1.TabIndex = 3;
        pergunta1.Text = "Já te uma conta? Clique aqui";
        // 
        // register
        // 
        register.AutoSize = true;
        register.Location = new Point(872, 389);
        register.Name = "register";
        register.Size = new Size(344, 65);
        register.TabIndex = 4;
        register.Text = "REGISTER";
        register.UseVisualStyleBackColor = true;
        register.Click += button1_Click_1;
        // 
        // pergunta2
        // 
        pergunta2.AutoSize = true;
        pergunta2.BackColor = Color.Transparent;
        pergunta2.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
        pergunta2.ForeColor = SystemColors.ButtonHighlight;
        pergunta2.Location = new Point(891, 342);
        pergunta2.Name = "pergunta2";
        pergunta2.Size = new Size(316, 26);
        pergunta2.TabIndex = 5;
        pergunta2.Text = "Não tem uma conta? crie uma";
        // 
        // DigiteSeuNome
        // 
        DigiteSeuNome.AutoSize = true;
        DigiteSeuNome.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DigiteSeuNome.ForeColor = SystemColors.Control;
        DigiteSeuNome.Location = new Point(876, 174);
        DigiteSeuNome.Name = "DigiteSeuNome";
        DigiteSeuNome.Size = new Size(233, 33);
        DigiteSeuNome.TabIndex = 6;
        DigiteSeuNome.Text = "Digite seu nome";
        DigiteSeuNome.Visible = false;
        // 
        // BoxNome
        // 
        BoxNome.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BoxNome.Location = new Point(876, 210);
        BoxNome.MaxLength = 40;
        BoxNome.Name = "BoxNome";
        BoxNome.Size = new Size(340, 34);
        BoxNome.TabIndex = 7;
        BoxNome.Visible = false;
        BoxNome.TextChanged += textBox1_TextChanged;
        // 
        // SeuEmal
        // 
        SeuEmal.AutoSize = true;
        SeuEmal.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        SeuEmal.ForeColor = SystemColors.Control;
        SeuEmal.Location = new Point(876, 293);
        SeuEmal.Name = "SeuEmal";
        SeuEmal.Size = new Size(315, 33);
        SeuEmal.TabIndex = 8;
        SeuEmal.Text = "Digite um email válido";
        SeuEmal.Visible = false;
        // 
        // BoxEmail
        // 
        BoxEmail.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BoxEmail.Location = new Point(876, 329);
        BoxEmail.MaxLength = 40;
        BoxEmail.Name = "BoxEmail";
        BoxEmail.Size = new Size(340, 34);
        BoxEmail.TabIndex = 9;
        BoxEmail.Visible = false;
        BoxEmail.TextChanged += BoxEmail_TextChanged;
        // 
        // SuaSenha
        // 
        SuaSenha.AutoSize = true;
        SuaSenha.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        SuaSenha.ForeColor = SystemColors.Control;
        SuaSenha.Location = new Point(876, 405);
        SuaSenha.Name = "SuaSenha";
        SuaSenha.Size = new Size(298, 54);
        SuaSenha.TabIndex = 10;
        SuaSenha.Text = "Crie uma senha!\r\nForte, no mínimo 8 dígitos\r\n";
        SuaSenha.Visible = false;
        // 
        // BoxSenha
        // 
        BoxSenha.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BoxSenha.Location = new Point(876, 462);
        BoxSenha.MaxLength = 16;
        BoxSenha.Name = "BoxSenha";
        BoxSenha.Size = new Size(340, 34);
        BoxSenha.TabIndex = 11;
        BoxSenha.Visible = false;
        BoxSenha.TextChanged += BoxSenha_TextChanged;
        // 
        // TextCriarConta
        // 
        TextCriarConta.AutoSize = true;
        TextCriarConta.ForeColor = SystemColors.ButtonHighlight;
        TextCriarConta.Location = new Point(782, 41);
        TextCriarConta.Name = "TextCriarConta";
        TextCriarConta.Size = new Size(415, 52);
        TextCriarConta.TabIndex = 12;
        TextCriarConta.Text = "CRIAR UMA CONTA";
        TextCriarConta.Visible = false;
        // 
        // buttonCriar
        // 
        buttonCriar.ForeColor = SystemColors.ActiveCaptionText;
        buttonCriar.Location = new Point(940, 531);
        buttonCriar.Name = "buttonCriar";
        buttonCriar.Size = new Size(192, 58);
        buttonCriar.TabIndex = 13;
        buttonCriar.Text = "CRIAR";
        buttonCriar.UseVisualStyleBackColor = true;
        buttonCriar.Visible = false;
        buttonCriar.Click += buttonCriar_Click;
        // 
        // BoxEntar1
        // 
        BoxEntar1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BoxEntar1.Location = new Point(848, 220);
        BoxEntar1.MaxLength = 40;
        BoxEntar1.Name = "BoxEntar1";
        BoxEntar1.Size = new Size(349, 34);
        BoxEntar1.TabIndex = 16;
        BoxEntar1.Visible = false;
        // 
        // SeuNomeLogin
        // 
        SeuNomeLogin.AutoSize = true;
        SeuNomeLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        SeuNomeLogin.ForeColor = SystemColors.Control;
        SeuNomeLogin.Location = new Point(848, 181);
        SeuNomeLogin.Name = "SeuNomeLogin";
        SeuNomeLogin.Size = new Size(383, 33);
        SeuNomeLogin.TabIndex = 15;
        SeuNomeLogin.Text = "Digite seu nome de usuário\r\n";
        SeuNomeLogin.Visible = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.ForeColor = SystemColors.ButtonHighlight;
        label3.Location = new Point(844, 227);
        label3.Name = "label3";
        label3.Size = new Size(335, 27);
        label3.TabIndex = 14;
        label3.Text = "Já te uma conta? Clique aqui";
        label3.Visible = false;
        // 
        // BoxEntar2
        // 
        BoxEntar2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BoxEntar2.Location = new Point(848, 326);
        BoxEntar2.MaxLength = 25;
        BoxEntar2.Name = "BoxEntar2";
        BoxEntar2.Size = new Size(340, 34);
        BoxEntar2.TabIndex = 19;
        BoxEntar2.Visible = false;
        // 
        // SuaSenhaLogin
        // 
        SuaSenhaLogin.AutoSize = true;
        SuaSenhaLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        SuaSenhaLogin.ForeColor = SystemColors.Control;
        SuaSenhaLogin.Location = new Point(857, 290);
        SuaSenhaLogin.Name = "SuaSenhaLogin";
        SuaSenhaLogin.Size = new Size(238, 33);
        SuaSenhaLogin.TabIndex = 18;
        SuaSenhaLogin.Text = "Digite sua senha";
        SuaSenhaLogin.Visible = false;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.ForeColor = SystemColors.ButtonHighlight;
        label4.Location = new Point(853, 336);
        label4.Name = "label4";
        label4.Size = new Size(335, 27);
        label4.TabIndex = 17;
        label4.Text = "Já te uma conta? Clique aqui";
        label4.Visible = false;
        // 
        // buttonEntar
        // 
        buttonEntar.ForeColor = SystemColors.ActiveCaptionText;
        buttonEntar.Location = new Point(932, 528);
        buttonEntar.Name = "buttonEntar";
        buttonEntar.Size = new Size(205, 58);
        buttonEntar.TabIndex = 20;
        buttonEntar.Text = "ENTRAR";
        buttonEntar.UseVisualStyleBackColor = true;
        buttonEntar.Visible = false;
        buttonEntar.Click += buttonEntar_Click;
        // 
        // TextEntar
        // 
        TextEntar.AutoSize = true;
        TextEntar.ForeColor = SystemColors.ButtonHighlight;
        TextEntar.Location = new Point(742, 41);
        TextEntar.Name = "TextEntar";
        TextEntar.Size = new Size(489, 52);
        TextEntar.TabIndex = 21;
        TextEntar.Text = "ENTRE NA SUA CONTA";
        TextEntar.Visible = false;
        // 
        // Voltar
        // 
        Voltar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Voltar.ForeColor = SystemColors.ActiveCaptionText;
        Voltar.Location = new Point(932, 606);
        Voltar.Name = "Voltar";
        Voltar.Size = new Size(207, 32);
        Voltar.TabIndex = 22;
        Voltar.Text = "VOLTAR";
        Voltar.UseVisualStyleBackColor = true;
        Voltar.Visible = false;
        Voltar.Click += Voltar_Click;
        // 
        // SairLogin
        // 
        SairLogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        SairLogin.Location = new Point(932, 658);
        SairLogin.Name = "SairLogin";
        SairLogin.Size = new Size(205, 41);
        SairLogin.TabIndex = 23;
        SairLogin.Text = "VOLTAR";
        SairLogin.UseVisualStyleBackColor = true;
        SairLogin.Click += SairLogin_Click;
        // 
        // Login_Cadastro
        // 
        AutoScaleDimensions = new SizeF(26F, 52F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Indigo;
        ClientSize = new Size(1231, 744);
        Controls.Add(SairLogin);
        Controls.Add(Voltar);
        Controls.Add(TextEntar);
        Controls.Add(buttonEntar);
        Controls.Add(BoxEntar2);
        Controls.Add(SuaSenhaLogin);
        Controls.Add(label4);
        Controls.Add(BoxEntar1);
        Controls.Add(SeuNomeLogin);
        Controls.Add(label3);
        Controls.Add(buttonCriar);
        Controls.Add(TextCriarConta);
        Controls.Add(BoxSenha);
        Controls.Add(SuaSenha);
        Controls.Add(BoxEmail);
        Controls.Add(SeuEmal);
        Controls.Add(BoxNome);
        Controls.Add(DigiteSeuNome);
        Controls.Add(pergunta2);
        Controls.Add(register);
        Controls.Add(pergunta1);
        Controls.Add(label1);
        Controls.Add(login);
        Controls.Add(Titulo);
        Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(10, 8, 10, 8);
        Name = "Login_Cadastro";
        Load += Login_Cadastro_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Titulo;
    private Button login;
    private Label label1;
    private Label pergunta1;
    private Button register;
    private Label pergunta2;
    private Label DigiteSeuNome;
    private TextBox BoxNome;
    private Label SeuEmal;
    private TextBox BoxEmail;
    private Label SuaSenha;
    private TextBox BoxSenha;
    private Label TextCriarConta;
    private Button buttonCriar;
    private TextBox BoxEntar1;
    private Label SeuNomeLogin;
    private Label label3;
    private TextBox BoxEntar2;
    private Label SuaSenhaLogin;
    private Label label4;
    private Button buttonEntar;
    private Label TextEntar;
    private Button Voltar;
    private Button SairLogin;
}






