using DesignPatternsProject.Objects.Enums;
using DesignPatternsProject.Objects.Models;
using DesignPatternsProject.Service.Entities;

namespace DesignPatternsProject.Service.States
{
    public class Pago : IEstadoPedido
    {
        public IEstadoPedido CancelarPedido()
        {
            return new Cancelado();
        }

        public IEstadoPedido DespacharPedido()
        {
            return new Enviado();
        }

        public IEstadoPedido SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi pago");
        }

    }
}
