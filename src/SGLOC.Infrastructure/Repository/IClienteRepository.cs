using SGLOC.ApplicationCore.Entity;
using SGLOC.ApplicationCore.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.Infrastructure.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteId);
    }
}
