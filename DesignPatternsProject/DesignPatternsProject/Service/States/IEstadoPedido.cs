using DesignPatternsProject.Objects.Models;
using DesignPatternsProject.Service.Entities;

namespace DesignPatternsProject.Service.States
{
    public interface IEstadoPedido
    {
        IEstadoPedido SucessoAoPagar();
        IEstadoPedido DespacharPedido();
        IEstadoPedido CancelarPedido();

    }
}
