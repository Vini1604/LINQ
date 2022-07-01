using LINQ.Classes;
using LINQ.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {

        static public List<Produto> Produtos { get; set; } = new List<Produto>();
        static public List<ItensNotaFiscal> Itens { get; set; } = new List<ItensNotaFiscal>();
        static public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        static public List<NotaFiscal> NotasFiscais { get; set; } = new List<NotaFiscal>();
        static void Main(string[] args)
        { 
            // CRIANDO 10 PRODUTOS
            Produto produto1 = new Produto { Id = 1, NomeProduto = "Banana" };
            Produto produto2 = new Produto { Id = 2, NomeProduto = "Melancia" };
            Produto produto3 = new Produto { Id = 3, NomeProduto = "Tomate" };
            Produto produto4 = new Produto { Id = 4, NomeProduto = "Maca" };
            Produto produto5 = new Produto { Id = 5, NomeProduto = "Laranja" };
            Produto produto6 = new Produto { Id = 6, NomeProduto = "Alface" };
            Produto produto7 = new Produto { Id = 7, NomeProduto = "Cebola" };
            Produto produto8 = new Produto { Id = 8, NomeProduto = "Abacaxi" };
            Produto produto9 = new Produto { Id = 9, NomeProduto = "Mamao" };
            Produto produto10 = new Produto { Id = 10, NomeProduto = "Manga" };

            //CRIANDO 10 CLIENTES
            Cliente cliente1 = new Cliente { Id = 1, NomeCliente = "Ana" };
            Cliente cliente2 = new Cliente { Id = 2, NomeCliente = "Bruno" };
            Cliente cliente3 = new Cliente { Id = 3, NomeCliente = "Camila" };
            Cliente cliente4 = new Cliente { Id = 4, NomeCliente = "Daniel" };
            Cliente cliente5 = new Cliente { Id = 5, NomeCliente = "Fernanda" };
            Cliente cliente6 = new Cliente { Id = 6, NomeCliente = "Gustavo" };
            Cliente cliente7 = new Cliente { Id = 7, NomeCliente = "Igor" };
            Cliente cliente8 = new Cliente { Id = 8, NomeCliente = "Larissa" };
            Cliente cliente9 = new Cliente { Id = 9, NomeCliente = "Juliana" };
            Cliente cliente10 = new Cliente { Id = 10, NomeCliente = "Marcelo" };

            // CRIANDO 10 NOTAS
            NotaFiscal nota1 = new NotaFiscal(1, cliente1, new DateTime(2022, 04, 10), TipoFreteEnum.CIF, StatusNotaEnum.Ativo);            
            NotaFiscal nota2 = new NotaFiscal (2, cliente2, new DateTime(2021, 03, 10), TipoFreteEnum.CIF, StatusNotaEnum.Ativo);
            NotaFiscal nota3 = new NotaFiscal (3, cliente3, new DateTime(2021, 09, 1), TipoFreteEnum.CIF, StatusNotaEnum.Faturado);
            NotaFiscal nota4 = new NotaFiscal (4, cliente4, new DateTime(2020, 01, 10), TipoFreteEnum.FOB, StatusNotaEnum.Faturado);
            NotaFiscal nota5 = new NotaFiscal (5, cliente5, new DateTime(2022, 06, 14), TipoFreteEnum.FOB, StatusNotaEnum.Cancelado);
            NotaFiscal nota6 = new NotaFiscal (6, cliente6, new DateTime(2022, 02, 17), TipoFreteEnum.CIF, StatusNotaEnum.Faturado);
            NotaFiscal nota7 = new NotaFiscal (7, cliente7, new DateTime(2022, 05, 13), TipoFreteEnum.CIF, StatusNotaEnum.Cancelado);
            NotaFiscal nota8 = new NotaFiscal (8, cliente8, new DateTime(2021, 12, 24), TipoFreteEnum.FOB, StatusNotaEnum.Ativo);
            NotaFiscal nota9 = new NotaFiscal (9, cliente9, new DateTime(2020, 10, 28), TipoFreteEnum.CIF, StatusNotaEnum.Ativo);
            NotaFiscal nota10 = new NotaFiscal (10, cliente10, new DateTime(2022, 05, 13),TipoFreteEnum.FOB, StatusNotaEnum.Cancelado);

            //CRIANDO 10 ITENS DE NOTA
            ItensNotaFiscal item1 = new ItensNotaFiscal (1, nota1, produto1, 2, 3.50M);
            ItensNotaFiscal item2 = new ItensNotaFiscal (2, nota1, produto2, 1, 7.00M);
            ItensNotaFiscal item3 = new ItensNotaFiscal (3, nota3, produto3, 10, 1.50M);
            ItensNotaFiscal item4 = new ItensNotaFiscal (4, nota4, produto4, 4, 4.00M);
            ItensNotaFiscal item5 = new ItensNotaFiscal (5, nota3, produto5, 6, 0.30M);
            ItensNotaFiscal item6 = new ItensNotaFiscal (6, nota1, produto6, 12, 0.50M);
            ItensNotaFiscal item7 = new ItensNotaFiscal (7, nota3, produto7, 5, 2.00M);
            ItensNotaFiscal item8 = new ItensNotaFiscal (8, nota4, produto8, 2, 10.50M);
            ItensNotaFiscal item9 = new ItensNotaFiscal (9, nota2, produto9, 5, 3.50M);
            ItensNotaFiscal item10 = new ItensNotaFiscal (10, nota10, produto10, 1, 3.20M);


            PopularLista(Produtos, produto1, produto2, produto3, produto4, produto5, produto6, produto7, produto8, produto9, produto10);
            PopularLista(Clientes, cliente1, cliente2, cliente3, cliente4, cliente5, cliente6, cliente7, cliente8, cliente9, cliente10);
            PopularLista(NotasFiscais, nota1, nota2, nota3, nota4, nota5, nota6, nota7, nota8, nota9, nota10);
            PopularLista(Itens, item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);

            //PRODUTOS A SEREM BUSCADOS
            string nomeProduto1 = "abacaxi";
            string nomeProduto2 = "laranja";

            ContarNotasFaturadas();
            ContarNotasCanceladas();
            EncontrarPrimeiraNotaAtiva();
            ContarProdutosNotasCIFAtivas();
            CustoTotalNotasFOBFaturadas();
            ContarProdutoXVendido(nomeProduto1);
            CustoTotalProdutosXYVendido(nomeProduto1, nomeProduto2);
            ImprimeNotas();
        }

        private static void CustoTotalNotasFOBFaturadas()
        {
            decimal valorFaturadoFOB = Itens.Where(x => x.NotaFiscal.Status == StatusNotaEnum.Faturado && x.NotaFiscal.TipoFrete == TipoFreteEnum.FOB).Sum(x => x.CalculaCustoTotal());
            Console.WriteLine($"Valor total de notas FOB faturadas: R$ {valorFaturadoFOB:F2}");
        }

        private static void ImprimeNotas()
        {
            var notas = AgruparItens();
            foreach(var nota in notas)
            {
                var cabecalhoNota = NotasFiscais.First(x => x.Id == nota.Key);
                Console.WriteLine(cabecalhoNota);
                foreach (var item in nota)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static IOrderedEnumerable<IGrouping<int, ItensNotaFiscal>> AgruparItens()
        {
            var agrupamento = from item in Itens
                        group item by item.IdNotaFiscal into grupoNotas
                        orderby grupoNotas.Key ascending
                        select grupoNotas;

            return agrupamento;
        }

        private static void CustoTotalProdutosXYVendido(string nomeProduto1, string nomeProduto2)
        {
            decimal totalVendido = Itens.Where(x => (x.Produto.NomeProduto.ToUpper().Contains(nomeProduto1.ToUpper()) || x.Produto.NomeProduto.ToUpper().Contains(nomeProduto2.ToUpper())) && x.NotaFiscal.Status == StatusNotaEnum.Faturado).Sum(x => x.CalculaCustoTotal());
            Console.WriteLine($"Preco total dos itens {nomeProduto1} e {nomeProduto2} vendido: R$ {totalVendido:F2}");
        }

        private static void ContarProdutoXVendido(string nomeProduto)
        {
            int quantidadeItemVendido = Itens.Where(x => x.Produto.NomeProduto.ToUpper().Contains(nomeProduto.ToUpper()) && x.NotaFiscal.Status == StatusNotaEnum.Faturado).Sum(x => x.Quantidade);
            Console.WriteLine($"Quantidade do item {nomeProduto} vendido: {quantidadeItemVendido}");
        }

        private static void ContarProdutosNotasCIFAtivas()
        {
            int quantidade = Itens.Where(x => x.NotaFiscal.Status == StatusNotaEnum.Ativo && x.NotaFiscal.TipoFrete == TipoFreteEnum.CIF).Sum(x => x.Quantidade);
            Console.WriteLine($"Produtos com notas CIF Ativas: {quantidade}");
        }

        private static void EncontrarPrimeiraNotaAtiva()
        {
            var primeiraNotaAtiva = NotasFiscais.Where(x => x.Status == StatusNotaEnum.Ativo).OrderBy(x => x.DataEmissao).FirstOrDefault();
            Console.WriteLine($"Id da primeira nota ativa: {primeiraNotaAtiva.Id}");
            Console.WriteLine($"Data da primeira nota ativa: {primeiraNotaAtiva.DataEmissao: dd/MM/yyyy}");
        }

        private static void ContarNotasCanceladas()
        {
            int notasCanceladas = NotasFiscais.Where(x => x.Status == StatusNotaEnum.Cancelado && x.DataEmissao.Date == new DateTime(2022, 05, 13).Date).Count();
            Console.WriteLine($"Notas canceladas: {notasCanceladas}");
        }

        private static void ContarNotasFaturadas()
        {
            int notasFaturadas = NotasFiscais.Where(x => x.Status == StatusNotaEnum.Faturado).Count();
            Console.WriteLine($"Notas faturadas: {notasFaturadas}");
        }

        static void PopularLista<T>(List<T> lista, T objeto1, T objeto2, T objeto3, T objeto4, T objeto5, T objeto6, T objeto7, T objeto8, T objeto9, T objeto10)
        {
            lista.Add(objeto1);
            lista.Add(objeto2);
            lista.Add(objeto3);
            lista.Add(objeto4);
            lista.Add(objeto5);
            lista.Add(objeto6);
            lista.Add(objeto7);
            lista.Add(objeto8);
            lista.Add(objeto9);
            lista.Add(objeto10);

        }
    }
}
