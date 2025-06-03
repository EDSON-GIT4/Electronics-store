using System;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using StorePessoas;
using MappCli;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ConnectDB;


namespace ConnectDB
{
    internal class Connect : DbContext
    {
        // DbSets representam as tabelas no banco de dados
        public DbSet<Cadastro_clientes> CadastroC { get;  set; }


        //Configura a conexão com o banco de PostgreSQL
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=pessoas;Username=cadastrar;Password=t446283746527");
        }
    }
}

// Mapeamento de tabela com Data Annotations(simples)
namespace MappCli 
{
    [Table("cadastro_clientes")]
    internal class Cadastro_clientes //Essa classe vai para o DbSet, tem o mesmo nome da tabela no banco de dados
    {
        
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("nome")]
        [Required]
        public string nome { get; set; }

        [Column("email")]
        [Required]
        public string email { get; set; }

        [Column("senha")]
        [Required]
        public string senha { get; set; }

        
    }
}






