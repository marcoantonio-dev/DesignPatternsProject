using DesignPatternsProject.Objects.Enums;
using DesignPatternsProject.Objects.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Threading;

namespace DesignPatternsProject.Data.Builders
{
    public class PedidoBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().HasKey(pg => pg.Id);
            modelBuilder.Entity<Pedido>().Property(pg => pg.Produto)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Pedido>().Property(pg => pg.Valor)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Pedido>().Property(pg => pg.SubTotal)
               .IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Pedido>()
                .HasData(new List<Pedido>
                {
                new Pedido(1, "Rato de Estimação", (float)8.3, (float)2.5, StatusPedido.Pago, TipoFrete.Terrestre),
                new Pedido(2, "Pc Gamer 4K Ultra HD Graphics RTX", (float)800.70, (float)25.5, StatusPedido.Pago, TipoFrete.Terrestre),
                new Pedido(3, "Boneco do Renato Russo", (float)30.00, (float)25.5, StatusPedido.Pago, TipoFrete.Terrestre),
                });
        }
    }
}
