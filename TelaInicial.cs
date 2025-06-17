using StorePessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace My_Store
{
    public partial class TelaInicial : Form
    {
           
        
        SettingsFile Setting = new SettingsFile();

        public TelaInicial()
        {
            InitializeComponent();
            this.FormClosing += TelaInicialForm;

            try
            {
                Setting.LoadArchive();

                

                if (Setting.Confirm == 5)
                {
                    ButtonConta.Visible = true;
                    ContaInativa.Visible = false;
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar usar informação de conta");
            }
        
        }

        private void TelaInicialForm(object sender, FormClosingEventArgs e) 
        {
            //Lógica de quando esse formulário for fechado
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
           
        }

        private void ContaInativa_Click(object sender, EventArgs e)
        {

            Login_Cadastro conta = new Login_Cadastro();

            conta.Show();

            //Assina o evento que dispara o fechamento da janela(Form2_Fechado())
            conta.FormClosing += Form2_Fechado;
        }

        private void Form2_Fechado(object sender, FormClosingEventArgs e)
        {
            // Atualize controles ou lógica aqui, para toda vez que a janela de login/cadastro é fechada

                try
                {
                    Setting.LoadArchive();
                    if (Setting.Confirm == 5)
                    {
                        ButtonConta.Visible = true;
                        ContaInativa.Visible = false;
                    }

                }
                catch
                {
                    MessageBox.Show("Não foi possivel carregar suas nformação de conta");
                }
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
