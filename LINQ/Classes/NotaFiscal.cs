using LINQ.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    class NotaFiscal
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public TipoFreteEnum TipoFrete { get; set; }
        public StatusNotaEnum Status { get; set; }
        public NotaFiscal()
        {

        }

    }
}
