using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace AmgSistemas.ControleMilhas.Api.BD
{
    public class BancoContext : DbContext
    {
        public DbSet<Models.AGCM_TUSUARIO> AGCM_TUSUARIO { get; set; }
        public DbSet<Models.AGCM_TMEMBROS> AGCM_TMEMBROS { get; set; }
        public DbSet<Models.AGCM_TEMPRESA> AGCM_TEMPRESA { get; set; }
        public DbSet<Models.AGCM_TPROGRAMA> AGCM_TPROGRAMA { get; set; }
        public DbSet<Models.AGCM_TCOTACAO> AGCM_TCOTACAO { get; set; }
        public DbSet<Models.AGCM_TMOVIMENTOS> AGCM_TMOVIMENTOS { get; set; }
        public DbSet<Models.AGCM_TMOV_PARCELA> AGCM_TMOV_PARCELA { get; set; }
        public DbSet<Models.AGCM_TSALDO> AGCM_TSALDO { get; set; }
        public DbSet<Models.AGCM_TSALDO_VENDA> AGCM_TSALDO_VENDA { get; set; }


        private readonly DbConnection _connection;

        public BancoContext(DbConnection connection)
        {
            _connection = connection;
        }


        public BancoContext(DbContextOptions options) : base(options)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (_connection != null)
            {
                optionsBuilder.UseSqlServer(_connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                  .Entity<Models.AGCM_TUSUARIO>(eb =>
                  {
                      eb.HasKey("ID_USUARIO");
                  });

            modelBuilder
                  .Entity<Models.AGCM_TMEMBROS>(eb =>
                  {
                      eb.HasKey("ID_MEMBRO");
                  });

            modelBuilder
                 .Entity<Models.AGCM_TEMPRESA>(eb =>
                 {
                     eb.HasKey("ID_EMPRESA");
                 });

            modelBuilder
                 .Entity<Models.AGCM_TPROGRAMA>(eb =>
                 {
                     eb.HasKey("ID_PROGRAMA");
                 });

            modelBuilder
                 .Entity<Models.AGCM_TCOTACAO>(eb =>
                 {
                     eb.HasKey("ID_COTACAO");
                 });

            modelBuilder
                 .Entity<Models.AGCM_TMOVIMENTOS>(eb =>
                 {
                     eb.HasKey("ID_MOVIMENTOS");
                 });

            modelBuilder
                 .Entity<Models.AGCM_TMOV_PARCELA>(eb =>
                 {
                     eb.HasKey("ID_MOV_PARCELA");
                 });

            modelBuilder
                 .Entity<Models.AGCM_TSALDO>(eb =>
                 {
                     eb.HasKey("ID_SALDO");
                 });

            modelBuilder
                 .Entity<Models.AGCM_TSALDO_VENDA>(eb =>
                 {
                     eb.HasKey("ID_SALDO_VENDA");
                 });
        }
    }
}
