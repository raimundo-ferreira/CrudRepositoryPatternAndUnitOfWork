using CrudRepositoryPatternAndUnitOfWork.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudRepositoryPatternAndUnitOfWork
{
    public class ApplicationDbContext : DbContext
    {
        // A propriedade DbSet dirá ao EF Core que temos uma tabela que precisa ser criada
        public virtual DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // A função de criação de modelo nos fornecerá a capacidade de gerenciar as propriedades das tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}