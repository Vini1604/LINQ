using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    class ItensNotaFiscal
    {
        public int Id { get; set; }
        public int IdNotaFiscal { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Total { get; private set; }
        public ItensNotaFiscal()
        {

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
