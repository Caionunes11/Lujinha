using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lujinha.WF.Entities
{
    public class PedidoResumo
    {
        public string Produto { get; set; }
        public double Preco { get; set; }
        public int QuantidadePecas { get; set; }
        public double Valor { get; set; }
    }
}
