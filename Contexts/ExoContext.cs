using Microsoft.EntityFrameworkCore;
using Exo.WebApi.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext(){}

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  
        {
            if(!optionsBuilder.IsConfigured)
            {
                // String de conexao própria
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;"+"Database=ExoApi;Trusted_Connection = True;");
                // Ex 1 de string de conexao: 
                // User ID=sa;Password=admin;Server=localhost;Database=ExoApi; +Trusted_Connection=False;

            }
        }
        public DbSet<Projeto> Projetos { get; set;}
        public DbSet<Usuario> Usuarios {get;set;}
    }

}