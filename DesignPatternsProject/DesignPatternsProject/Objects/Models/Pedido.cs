﻿using DesignPatternsProject.Objects.Enums;
using DesignPatternsProject.Service.States;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Xml.Linq;

namespace DesignPatternsProject.Objects.Models
{
    [Table("pedido")]
    public class Pedido
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("produto")]
        public string Produto { get; set; }

        [Column("valor")]
        public float Valor { get; set; }

        [Column("subtotal")]
        public float SubTotal { get; set; }

        [Column("statuspedido")]
        public StatusPedido StatusPedido { get; set; }

        [Column("tipofrete")]
        public TipoFrete TipoFrete { get; set; }
        
        public Pedido() { }
        public Pedido(int id, string produto, float valor, float subtotal, StatusPedido statusPedido, TipoFrete tipoFrete)
        {
            Id = id;
            Produto = produto;
            Valor = valor;
            SubTotal = subtotal;
            StatusPedido = StatusPedido.AguardandoPagamento;
            TipoFrete = tipoFrete;
        }     
    }
}
