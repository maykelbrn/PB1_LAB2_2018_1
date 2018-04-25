using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.ApplicationCore.Entity
{
    public class Locacao
    {
        public Locacao()
        {

        }

        public int LocacaoId { get; set; }
        public int Numero { get; set; }
        public DateTime DataLocacao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

    }
}
