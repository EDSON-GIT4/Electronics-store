using System;
using ConnectDB;
using StorePessoas;
using MappCli;
using Npgsql;

namespace My_Store
{
    internal static class Program 
    {
        
        [STAThread]
        static void Main()
        {
            

            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaInicial());  // Responsavel por iniciar o formulário
            //Application.Run(new Login_Cadastro());  // Responsavel por iniciar o formulário
            
        }
    }
}