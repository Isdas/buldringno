using BuldringNo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BuldringNo.Infrastructure
{
    public class BuldringNoContext : DbContext
    {
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Boulder> Boulders { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Error> Errors { get; set; }

        public BuldringNoContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
                entity.Relational().TableName = entity.ClrType.Name;

            // Problems
            modelBuilder.Entity<Problem>().Property(p => p.Title).HasMaxLength(100);
            modelBuilder.Entity<Problem>().Property(p => p.BoulderId).IsRequired();
            modelBuilder.Entity<Problem>().Property(p => p.Grade).HasMaxLength(3);

            // Boulder
            modelBuilder.Entity<Boulder>().Property(b => b.Title).HasMaxLength(100);
            modelBuilder.Entity<Boulder>().Property(b => b.AreaId).IsRequired();
            modelBuilder.Entity<Boulder>().Property(b => b.Description).HasMaxLength(500);
            modelBuilder.Entity<Boulder>().HasMany(b => b.Problems).WithOne(b => b.Boulder);

            // Area
            modelBuilder.Entity<Area>().Property(a => a.Title).HasMaxLength(100);
            modelBuilder.Entity<Area>().Property(a => a.Description).HasMaxLength(500);
            modelBuilder.Entity<Area>().HasMany(a => a.Boulders).WithOne(a => a.Area);

            // User
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.Salt).IsRequired().HasMaxLength(200);

            // UserRole
            modelBuilder.Entity<UserRole>().Property(ur => ur.UserId).IsRequired();
            modelBuilder.Entity<UserRole>().Property(ur => ur.RoleId).IsRequired();

            // Role
            modelBuilder.Entity<Role>().Property(r => r.Name).IsRequired().HasMaxLength(50);
        }
    }
}
