using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimAppmvc2.Models
{
    public class Context : DbContext 
    {
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost\SQLEXPRESS;Database=CursoMvc;Integrated Security=True");
        }
    }
}
