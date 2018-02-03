using Microsoft.EntityFrameworkCore;
using TS.DTO.Classes;


namespace TS.DAL
{
    public class Context : DbContext
    {
      
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<RelatorioVenda> Relatorios { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=desafio02;Trusted_Connection=true;MultipleActiveResultSets=True");
        }
    }
}
