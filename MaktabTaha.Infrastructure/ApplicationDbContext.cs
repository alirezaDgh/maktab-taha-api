using MaktabTaha.Domain.Entites;
using MaktabTaha.Infrastructure.Mapping.user;
using MaktabTaha.Infrastructure.Mapping.user_permission;
using Microsoft.EntityFrameworkCore;

namespace MaktabTaha.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new UserPermissionMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
