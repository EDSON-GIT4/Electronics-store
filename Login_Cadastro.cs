using Microsoft.Win32;
using StorePessoas;
using System.Diagnostics.CodeAnalysis;

namespace My_Store
{

    public partial class Login_Cadastro : Form
    {

        public Login_Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Visible false button register
            register.Visible = false;
            pergunta2.Visible = false;
            login.Visible = false;
            pergunta1.Visible = false;

            //Visible true button credenciais
            TextEntar.Visible = true;
            SeuNomeLogin.Visible = true;
            BoxEntar1.Visible = true;
            SuaSenhaLogin.Visible = true;
            BoxEntar2.Visible = true;

            buttonEntar.Visible = true;
            Voltar.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Visible false button register
            register.Visible = false;
            pergunta2.Visible = false;
            login.Visible = false;
            pergunta1.Visible = false;

            //Visible true button credenciais

            TextCriarConta.Visible = true;

            DigiteSeuNome.Visible = true;
            SeuEmal.Visible = true;
            SuaSenha.Visible = true;

            BoxNome.Visible = true;
            BoxEmail.Visible = true;
            BoxSenha.Visible = true;

            buttonCriar.Visible = true;
            Voltar.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        public void BoxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Registration registro = new Registration();
            


            //nome
            if (string.IsNullOrWhiteSpace(BoxNome.Text))
            {
                BoxNome.BackColor = Color.LightPink; // Muda a cor de fundo
                BoxNome.Focus();
                MessageBox.Show("Seu nome não pode ser vazio!");

            }
            else
            {
                registro.Name_users = BoxNome.Text;
                BoxNome.BackColor = Color.White;

            }

            //email
            if (string.IsNullOrWhiteSpace(BoxEmail.Text))
            {

                BoxEmail.BackColor = Color.LightPink; // Muda a cor de fundo
                BoxEmail.Focus();
                MessageBox.Show("Seu email não pode ser vazio!");

            }
            else
            {
                registro.Email_users = BoxEmail.Text;
                BoxEmail.BackColor = Color.White;
                

            }

            //senha
            if (string.IsNullOrWhiteSpace(BoxSenha.Text))
            {
                BoxSenha.BackColor = Color.LightPink; // Muda a cor de fundo
                BoxSenha.Focus();
                MessageBox.Show("Sua senha não pode ser vazia!");
                
            }
            else
            {
                registro.Password_users = BoxSenha.Text;
                BoxSenha.BackColor = Color.White;
                if (registro.Name_users != null && registro.Email_users != null && registro.Password_users != null)
                {
                    registro.InputRegistration();

                    switch (registro.Confirm)
                    {
                        case 0: MessageBox.Show("A operação não iniciou"); break;
                        case 1: MessageBox.Show("Sua conta foi criada com sucesso!!"); break;
                        case 2: MessageBox.Show("Há um usuário cadastrado com esse email"); break;
                        case 3: MessageBox.Show("Há algo de errado com o programa, verifique sua conexão"); break;
                    }
                }
            }

        }
            

        private void Voltar_Click(object sender, EventArgs e)
        {
            //Tornar visivel a tela padrão de login e cadastro
            register.Visible = true;
            pergunta2.Visible = true;
            login.Visible = true;
            pergunta1.Visible = true;

            //Entrar: deve ser tudo false 
            TextEntar.Visible = false;
            SeuNomeLogin.Visible = false;
            BoxEntar1.Visible = false;
            SuaSenhaLogin.Visible = false;
            BoxEntar2.Visible = false;

            buttonEntar.Visible = false;
            Voltar.Visible = false;

            //Criar conta: deve ser tudo false 
            TextCriarConta.Visible = false;

            DigiteSeuNome.Visible = false;
            SeuEmal.Visible = false;
            SuaSenha.Visible = false;

            BoxNome.Visible = false;
            BoxEmail.Visible = false;
            BoxSenha.Visible = false;


            buttonCriar.Visible = false;
            Voltar.Visible = false;

            //limpar box de cadastro
            BoxNome.Clear();
            BoxEmail.Clear();
            BoxSenha.Clear();

            //limpar box de login
            BoxEntar1.Clear();
            BoxEntar2.Clear();

        }

        private void buttonEntar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            //nome
            if (string.IsNullOrWhiteSpace(BoxEntar1.Text))
            {
                BoxEntar1.BackColor = Color.LightPink; // Muda a cor de fundo
                BoxEntar1.Focus();
                MessageBox.Show("Você não digitou seu nome!");

            }
            else
            {
                login.Name_users = BoxEntar1.Text;
                BoxEntar1.BackColor = Color.White;

            }

            //senha
            if (string.IsNullOrWhiteSpace(BoxEntar2.Text))
            {
                BoxEntar2.BackColor = Color.LightPink; // Muda a cor de fundo
                BoxEntar2.Focus();
                MessageBox.Show("Você não digitou uma senha!");
                login.Password_users = null;
            }
            else
            {
                if (login.Name_users != null && login.Password_users != null) {
                    login.Password_users = BoxEntar2.Text;
                    BoxEntar2.BackColor = Color.White;
                    login.InputLogin();

                    switch (login.Confirm)
                    {
                        case 0: MessageBox.Show("O usuário e/ou senha digitados incorretamente"); break;
                        case 1: MessageBox.Show("O usuário existe"); break;
                        case 2: MessageBox.Show("Há Algo errado com o programa, verifique sua conexão"); break;

                    }
                }
            }
        }
    }

}