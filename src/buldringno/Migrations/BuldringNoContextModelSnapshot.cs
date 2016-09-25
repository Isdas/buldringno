using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BuldringNo.Infrastructure;

namespace BuldringNo.Migrations
{
    [DbContext(typeof(BuldringNoContext))]
    partial class BuldringNoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BuldringNo.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApproachTime")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DescriptionMain")
                        .HasAnnotation("MaxLength", 250);

                    b.Property<string>("DescriptionSecondary")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("Parking")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("BuldringNo.Entities.Boulder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("DescriptionMain")
                        .HasAnnotation("MaxLength", 250);

                    b.Property<string>("DescriptionSecondary")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<double>("GPSNorth")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<double>("GPSSouth")
                        .HasAnnotation("MaxLength", 10);

                    b.Property<string>("Return")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Boulder");
                });

            modelBuilder.Entity("BuldringNo.Entities.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.HasKey("Id");

                    b.ToTable("Error");
                });

            modelBuilder.Entity("BuldringNo.Entities.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoulderId");

                    b.Property<DateTime>("DateUploaded");

                    b.Property<string>("DescriptionMain")
                        .HasAnnotation("MaxLength", 250);

                    b.Property<string>("DescriptionSecondary")
                        .HasAnnotation("MaxLength", 1000);

                    b.Property<string>("FirstClimberSitStart")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime>("FirstClimberSitStartDate")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("FirstClimberStanding")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime>("FirstClimberStandingDate")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("GradeSitStart")
                        .HasAnnotation("MaxLength", 3);

                    b.Property<string>("GradeStandingStart")
                        .HasAnnotation("MaxLength", 3);

                    b.Property<double>("Height")
                        .HasAnnotation("MaxLength", 3);

                    b.Property<int>("NumberOfPads")
                        .HasAnnotation("MaxLength", 1);

                    b.Property<int>("NumberOfStars")
                        .HasAnnotation("MaxLength", 1);

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Uri");

                    b.HasKey("Id");

                    b.HasIndex("BoulderId");

                    b.ToTable("Problem");
                });

            modelBuilder.Entity("BuldringNo.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("BuldringNo.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BuldringNo.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("BuldringNo.Entities.Boulder", b =>
                {
                    b.HasOne("BuldringNo.Entities.Area", "Area")
                        .WithMany("Boulders")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BuldringNo.Entities.Problem", b =>
                {
                    b.HasOne("BuldringNo.Entities.Boulder", "Boulder")
                        .WithMany("Problems")
                        .HasForeignKey("BoulderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BuldringNo.Entities.UserRole", b =>
                {
                    b.HasOne("BuldringNo.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BuldringNo.Entities.User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
