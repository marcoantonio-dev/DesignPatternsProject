using AutoMapper;
using DesignPatternsProject.Objects.Dtos.Entities;
using DesignPatternsProject.Objects.Models;
using DesignPatternsProject.Service;
using System.Runtime;

namespace DesignPatternsProject.Objects.Dtos.Mappings
{
    public class PedidoMapping : Profile
    {
        public PedidoMapping()
        {
            CreateMap<PedidoDTO, Pedido>().ReverseMap();
        }
    }
}
