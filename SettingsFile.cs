using StorePessoas;
using System;
using System.Text.Json;


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

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel salvar seus arquivos");
            }
        }


        public void LoadArchive() 
        {
            string fileName = "Credenciais.json";
            string jsonString = File.ReadAllText(fileName);
            var Settings = JsonSerializer.Deserialize<SettingsFile>(jsonString)!;
        }
    }
}
