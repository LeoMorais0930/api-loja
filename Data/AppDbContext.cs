using Lojinha_Jorges.Models;
using Microsoft.EntityFrameworkCore;

namespace Lojinha_Jorges.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Defina suas entidades (tabelas) aqui
        public DbSet<Produto> Produtos { get; set; }
    }

}
