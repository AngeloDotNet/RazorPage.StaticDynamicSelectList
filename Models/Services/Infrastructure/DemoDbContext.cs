using Microsoft.EntityFrameworkCore;
using SelectListMvc_Load_Static_Dynamic.Models.Entities;

namespace SelectListMvc_Load_Static_Dynamic.Models.Services.Infrastructure
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {

        }

        public DbSet<User> Utenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Utenti");
                entity.HasKey(utente => utente.Id);
            });
        }
    }
}