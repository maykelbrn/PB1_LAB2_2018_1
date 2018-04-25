using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.ApplicationCore.Entity
{
    public class Veiculo
    {
        public Veiculo()
        {

        }

        public int VeiculoId { get; set; }
        public String Descricao { get; set; }
        public String Placa { get; set; }
        public ICollection<Locacao> Locacoes { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

    }
}
