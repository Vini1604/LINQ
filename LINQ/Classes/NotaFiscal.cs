using LINQ.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    class NotaFiscal
    {
        public int Id { get; set; }
        public int IdCliente { get; private set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public TipoFreteEnum TipoFrete { get; set; }
        public StatusNotaEnum Status { get; set; }
        public NotaFiscal()
        {

        }

        public NotaFiscal(int id, Cliente cliente, DateTime dataEmissao, TipoFreteEnum tipoFrete, StatusNotaEnum status)
        {
            Id = id;
            IdCliente = cliente.Id;
            Cliente = cliente;
            DataEmissao = dataEmissao;
            TipoFrete = tipoFrete;
            Status = status;
        }

        public override string ToString()
        {
            StringBuilder cabecalho = new StringBuilder();
            cabecalho.AppendLine($"********* Pedido {Id} - Emitido em: {DataEmissao:dd/MM/yyyy HH:mm:ss} - Tipo de Frete: {TipoFrete} - Status: {Status}");
            cabecalho.AppendLine($"Cliente: {IdCliente} - {Cliente.NomeCliente}");
            cabecalho.AppendLine();
            cabecalho.AppendLine("--------------- Itens do pedido ---------------");
            cabecalho.AppendLine("Produto".PadRight(25) + " qtde.".PadRight(10) + " Valor unitario".PadRight(25) + " Total".PadRight(15));
            return cabecalho.ToString();
           
        }
    }
}
