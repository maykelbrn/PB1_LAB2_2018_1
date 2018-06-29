using SGLOC.ApplicationCore.Entity;
using SGLOC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SGLOC.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext) : base(dbContext)
        {

        }

        public Cliente ObterPorProfissao(int clienteId)
        {
            return Buscar(x=> x.ProfissoesClientes.Any(p=> p.ClienteId == clienteId))
                .FirstOrDefault();
       
        }
    }
}
