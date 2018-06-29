using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.ApplicationCore.Entity
{
    class Profissao
    {
        public Profissao()
        {

        }

        public int ProfissaoId { get; set; }
        public int Nome { get; set; }
        public int Descricao { get; set; }
        public int CBO { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
