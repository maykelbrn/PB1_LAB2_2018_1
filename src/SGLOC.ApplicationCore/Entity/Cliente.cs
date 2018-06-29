using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public ICollection<Locacao> Locacoes { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
