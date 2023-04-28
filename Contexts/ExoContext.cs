using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Options;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        /* public ExoContext()
         {
         }*/
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*Essa string de conexão depende de como voce usa a máquina.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" 
                + "Database=ExoApi;Trusted_Connection=True;");*/

                //Exemplo 01 de string de conexão:

                // 01 Como usuario (User).
                optionsBuilder.UseSqlServer("ID=sa;Password=12345;Server=localhost;Database=ExoApi; Trusted_Connection=False;");

                /* 02 Como string de conexão
                Server=local\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True; */
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}