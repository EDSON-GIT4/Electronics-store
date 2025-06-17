using ConnectDB;
using MappCli;
using StorePessoas;
using System;
using System.Text.Json;
using System.Threading.Tasks;


namespace My_Store
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string password { get; set; }
        public bool Remenber { get; set; }

    }

    internal class SettingsFile : Users
    {
        

        public void SaveArchive(string N, string P) 
        {
            var Dados = new Pessoa
            {
                Nome = N,
                password = P,
                Remenber = true
            };

            string fileName = "Credenciais.json";

          
            try
            {
                string jsonString = JsonSerializer.Serialize(Dados);
                File.WriteAllText(fileName, jsonString);
                Confirm = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel salvar seus arquivos");
            }
        }


        public void LoadArchive() 
        {
            
            

            try
            {
                
                string jsonString = File.ReadAllText("Credenciais.json");
                Pessoa Settings = JsonSerializer.Deserialize<Pessoa>(jsonString)!;


                using (var context = new Connect())
                {
                    
                       var EntrarCliente = new Cadastro_clientes();
                        {
                            //Abaixo eu errei ao fazer conparação em texto puro(mude isso em versões futuras)
                            var usuario = context.CadastroC
                                .FirstOrDefault(u => u.nome == Settings.Nome && u.senha == Settings.password);
                            if (usuario != null)
                            {
                                Confirm = 5;

                            }

                        }

                }

            }
            catch
            {
                if (!File.Exists("Credenciais.json")) 
                {
                   
                }
                else 
                {
                    MessageBox.Show("Error loading. Você ou banco de de dados está Offline");
                }
                
                
            }
            
        }
    }
}
