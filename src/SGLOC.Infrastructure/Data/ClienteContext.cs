using Microsoft.EntityFrameworkCore;
using SGLOC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOC.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Locacao>().ToTable("Locacao");
            modelBuilder.Entity<Marca>().ToTable("Marca");
            modelBuilder.Entity<Veiculo>().ToTable("Veiculo");

            #region Configurações de Cliente
            modelBuilder.Entity<Cliente>().Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region Configurações de Endereço
            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Numero)
                .HasColumnType("varchar(15)")
                .IsRequired();
            #endregion

            #region Configurações de Locação
            modelBuilder.Entity<Locacao>().Property(e => e.Numero)
                .HasColumnType("varchar(15)")
                .IsRequired();
            #endregion

            #region Configurações de Marca
            modelBuilder.Entity<Marca>().Property(e => e.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region Configurações de Veiculo
            modelBuilder.Entity<Veiculo>().Property(e => e.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Veiculo>().Property(e => e.Placa)
                .HasColumnType("varchar(10)")
                .IsRequired();
            #endregion


        }
    }
}
