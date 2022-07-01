using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    class ItensNotaFiscal
    {
        public int Id { get; set; }
        public int IdNotaFiscal { get; private set; }
        public int IdProduto { get; private set; }
        public NotaFiscal NotaFiscal { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Total { get; private set; }
        public ItensNotaFiscal()
        {

        }

        public ItensNotaFiscal(int id, NotaFiscal notaFiscal, Produto produto, int quantidade, decimal valorUnitario)
        {
            Id = id;
            IdNotaFiscal = notaFiscal.Id;
            IdProduto = produto.Id;
            NotaFiscal = notaFiscal;
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public decimal CalculaCustoTotal()
        {
            Total = ValorUnitario * Quantidade;
            return Total;
        }

        public override string ToString()
        {
            StringBuilder itens = new StringBuilder();
            itens.AppendLine($"{Produto.NomeProduto,-25} {Quantidade, -10} {ValorUnitario, -25} {CalculaCustoTotal().ToString("F2"), -15}");
            return itens.ToString();
        }
    }
}
