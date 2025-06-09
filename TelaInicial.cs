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

namespace My_Store
{
    public partial class TelaInicial : Form
    {
        
        

        public TelaInicial()
        {
            InitializeComponent();

            
            
        }

        

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
           
        }

        private void ContaInativa_Click(object sender, EventArgs e)
        {

            Login_Cadastro conta = new Login_Cadastro();

            conta.Show();

            //Assina o evento que dispara o fechamento da janela(Form2_Fechado())
            conta.FormClosed += Form2_Fechado;
        }

        private void Form2_Fechado(object sender, FormClosedEventArgs e)
        {
            // Atualize controles ou lógica aqui, para toda vez que a janela de login/cadastro é fecahada

            

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
