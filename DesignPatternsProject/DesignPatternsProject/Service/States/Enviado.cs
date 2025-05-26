using DesignPatternsProject.Objects.Enums;
using DesignPatternsProject.Objects.Models;
using DesignPatternsProject.Service.Entities;

namespace DesignPatternsProject.Service.States
{
    public class Enviado : IEstadoPedido
    {
        public IEstadoPedido CancelarPedido()
        {
            throw new Exception("Operação não suportada, o pedido já foi enviado");
        }

        public IEstadoPedido DespacharPedido()
        {
            throw new Exception("Operação não suportada, o pedido já foi enviado");
        }

        public IEstadoPedido SucessoAoPagar()
        {
            throw new Exception("Operação não suportada, o pedido já foi enviado");
        }
    }
}
