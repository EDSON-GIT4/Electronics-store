using System;

using ConnectDB;
using MappCli;
using Microsoft.EntityFrameworkCore;
using My_Store;
using Npgsql;


namespace StorePessoas
{
    internal class Users
    {
        private string name_users;
        private string email_users;
        private string password_users;
        private byte confirm = 0;  //numero de status
        //private bool remenber = false;

        public string Name_users { get => name_users; set => name_users = value;}
        public string Email_users { get => email_users; set => email_users = value;}
        public string Password_users { get => password_users; set => password_users = value;}
        public byte Confirm { get => confirm; set => confirm = value;}
        //public bool Remenber { get => remenber; set => remenber = value;}

    }

    internal class Registration() : Users    //Users é classe abstrata
    {
        
        public void InputRegistration() //Método principal de registro
        {

            using (var context = new Connect())
            {

                try
                {
                    //Esse using garante que o objeto (Connect no caso) seja automaticamente descartado (disposed)
                    //quando o bloco terminar, mesmo que ocorra uma exceção.
                    using (var input = new Connect())
                    {

                        var NovoCliente = new Cadastro_clientes();
                        {
                            NovoCliente.nome = Name_users;
                            NovoCliente.email = Email_users;
                            NovoCliente.senha = Password_users;
                        };

                        input.CadastroC.Add(NovoCliente); // Adiciona ao contexto
                        input.SaveChanges();             // Persiste no banco
                        Confirm = 1;

                       
                        
                    }

                }
                catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx && pgEx.SqlState == "23505")
                {
                    Confirm = 2;
                }
                catch (Npgsql.PostgresException ex) when (ex.SqlState == "28P01") {
                    Confirm = 3;
                }

            }
        }
    }

    internal class Login : Users    //Users é a classe a classe abstrata
    {
        public void InputLogin() //Método principal de registro
        {
            using (var context = new Connect())
            {
                try
                {
                    var EntrarCliente = new Cadastro_clientes();
                    {
                        //Abaixo eu errei ao fazer conparação em texto puro(mude isso em versões futuras)
                        var usuario = context.CadastroC
                            .FirstOrDefault(u => u.nome == Name_users && u.senha == Password_users);
                        if (usuario != null)
                        {
                            Confirm = 1;

                            SettingsFile conta = new SettingsFile();
                            conta.SaveArchive(Name_users, Password_users);
                            
                        }
                       
                    };
                }
                catch
                {
                    Confirm = 2;
                }
                
            }

        }
    }

    
}
