using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SGLOC.ApplicationCore.Entity;

namespace SGLOC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initializer(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente {
                    Nome = "Maykel Bruno",
                    Email = "maykelbrn@gmail.com"
                },

                new Cliente {
                    Nome = "Franciele Dayane",
                    Email = "fran10_ciele@hotmail.com"
                }
            };

            context.AddRange(clientes);

            var enderecos = new Endereco[]
            {
                new Endereco {
                    Bairro = "CPA II",
                    CEP = "78055-434",
                    Logradouro = "Casa",
                    Numero = "10",
                    Cliente = clientes[0]
                },

                new Endereco {
                    Bairro = "CPA III",
                    CEP = "78055-535",
                    Logradouro = "Casa",
                    Numero = "15",
                    Cliente = clientes[1]

                }
            };

            context.AddRange(enderecos);

            var locacoes = new Locacao[]
            {
                new Locacao {
                    Numero = 10,
                    Cliente = clientes[0]

                },

                new Locacao {
                    Numero = 20,
                    Cliente = clientes[1]

                }
            };

            context.AddRange(locacoes);

            var marcas = new Marca[]
            {
                new Marca {
                    Descricao = "BMW"

                },

                new Marca {
                    Descricao = "Ferrari"
                }
            };

            context.AddRange(marcas);

            var veiculos = new Veiculo[]
           {
                new Veiculo {
                    Descricao = "Branco",
                    Placa = "OMB-1215",
                    Marca = marcas[0]
                },

                new Veiculo {
                    Descricao = "Preto",
                    Placa = "QBW-1114",
                    Marca = marcas[1]
                }
           };

            context.AddRange(veiculos);

            context.SaveChanges();
        }
    }
}
