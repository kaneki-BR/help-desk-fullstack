using Microsoft.EntityFrameworkCore;
using SistemaChamados.Api.Models;

namespace SistemaChamados.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Aqui você diz: "Eu quero uma tabela chamada 'Chamados' baseada na classe 'Chamado'"
        public DbSet<Chamado> Chamados { get; set; }
    }
}
