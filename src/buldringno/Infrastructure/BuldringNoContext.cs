﻿using BuldringNo.Entities;
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
            modelBuilder.Entity<Problem>().Property(b => b.DescriptionMain).HasMaxLength(250);
            modelBuilder.Entity<Problem>().Property(b => b.DescriptionSecondary).HasMaxLength(1000);
            modelBuilder.Entity<Problem>().Property(p => p.BoulderId).IsRequired();
            modelBuilder.Entity<Problem>().Property(p => p.GradeStandingStart).HasMaxLength(3);
            modelBuilder.Entity<Problem>().Property(p => p.GradeSitStart).HasMaxLength(3);
            modelBuilder.Entity<Problem>().Property(p => p.Height).HasMaxLength(3);
            modelBuilder.Entity<Problem>().Property(p => p.NumberOfStars).HasMaxLength(1);
            modelBuilder.Entity<Problem>().Property(p => p.NumberOfPads).HasMaxLength(1);
            modelBuilder.Entity<Problem>().Property(p => p.FirstClimberStanding).HasMaxLength(100);
            modelBuilder.Entity<Problem>().Property(p => p.FirstClimberSitStart).HasMaxLength(100);
            modelBuilder.Entity<Problem>().Property(p => p.FirstClimberStandingDate).HasMaxLength(100);
            modelBuilder.Entity<Problem>().Property(p => p.FirstClimberSitStartDate).HasMaxLength(100);

            // Boulder
            modelBuilder.Entity<Boulder>().Property(b => b.Title).HasMaxLength(100);
            modelBuilder.Entity<Boulder>().Property(b => b.DescriptionMain).HasMaxLength(250);
            modelBuilder.Entity<Boulder>().Property(b => b.DescriptionSecondary).HasMaxLength(1000);
            modelBuilder.Entity<Boulder>().Property(b => b.Return).HasMaxLength(100);
            modelBuilder.Entity<Boulder>().Property(b => b.GPSNorth).HasMaxLength(10);
            modelBuilder.Entity<Boulder>().Property(b => b.GPSSouth).HasMaxLength(10);
            modelBuilder.Entity<Boulder>().Property(b => b.AreaId).IsRequired();
            modelBuilder.Entity<Boulder>().HasMany(b => b.Problems).WithOne(b => b.Boulder);

            // Area
            modelBuilder.Entity<Area>().Property(a => a.Title).HasMaxLength(100);
            modelBuilder.Entity<Area>().Property(a => a.DescriptionMain).HasMaxLength(250);
            modelBuilder.Entity<Area>().Property(a => a.DescriptionSecondary).HasMaxLength(1000);
            modelBuilder.Entity<Area>().Property(a => a.Parking).HasMaxLength(100);
            modelBuilder.Entity<Area>().Property(a => a.ApproachTime).HasMaxLength(100);
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
