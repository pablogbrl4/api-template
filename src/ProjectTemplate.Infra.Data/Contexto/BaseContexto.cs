using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Infra.Data.Mappings;
using System;
using System.Threading.Tasks;

namespace ProjectTemplate.Infra.Data.Contexto
{
    public class BaseContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<EdificacoesMoradores> EdificacoesMoradores { get; set; }

        public DbSet<Edificacoes> Edificacoes { get; set; }

        public DbSet<PontosEncontro> PontosEncontros { get; set; }


        protected IDbContextTransaction _contextoTransaction { get; set; }

        public BaseContexto(DbContextOptions<BaseContexto> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public async Task<IDbContextTransaction> IniciarTransaction()
        {
            if (_contextoTransaction == null)
            {
                _contextoTransaction = await this.Database.BeginTransactionAsync();
            }
            return _contextoTransaction;
        }


        private async Task RollBack()
        {
            if (_contextoTransaction != null)
            {
                await _contextoTransaction.RollbackAsync();
            }
        }

        private async Task Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await RollBack();
                throw new Exception(ex.Message);
            }
        }

        private async Task Commit()
        {
            if (_contextoTransaction != null)
            {
                await _contextoTransaction.CommitAsync();
                await _contextoTransaction.DisposeAsync();
                _contextoTransaction = null;
            }
        }

        public async Task SalvarMudancas()
        {
            await Salvar();
            await Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());

            modelBuilder.ApplyConfiguration(new EdificacoesMoradoresMap());

            modelBuilder.ApplyConfiguration(new EdificacoesMap());

            modelBuilder.ApplyConfiguration(new PontosEncontroMap());
        }
    }
}
