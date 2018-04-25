using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.ApplicationCore.Entity
{
    public class Marca
    {
        public Marca()
        {

        }

        public int MarcaId { get; set; }
        public string Descricao { get; set; }
        public ICollection<Veiculo> Veiculos { get; set; }

    }
}
