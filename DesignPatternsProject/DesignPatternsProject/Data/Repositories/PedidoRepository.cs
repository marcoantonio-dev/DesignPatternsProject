using DesignPatternsProject.Data.Interfaces;
using DesignPatternsProject.Objects.Models;
using System.Threading;

namespace DesignPatternsProject.Data.Repositories
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
