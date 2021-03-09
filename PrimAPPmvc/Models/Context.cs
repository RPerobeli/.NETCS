using Microsoft.EntityFrameworkCore;

namespace PrimAPPmvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\SQLEXPRESS;Database=PrimAPPMVC;Trusted_Connection=True,Integrated Security=True");
        }
    }
}