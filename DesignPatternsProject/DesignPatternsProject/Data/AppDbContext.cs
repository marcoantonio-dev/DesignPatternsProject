using DesignPatternsProject.Data.Builders;
using DesignPatternsProject.Objects.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace DesignPatternsProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            PedidoBuilder.Build(modelBuilder);

        }
    }
}
