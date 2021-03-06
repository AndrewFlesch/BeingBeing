﻿// <auto-generated />
using BeingBeing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BeingBeing.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeingBeing.Models.Appetite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Appetite");
                });

            modelBuilder.Entity("BeingBeing.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BeingBeing.Models.Consuming", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Beans");

                    b.Property<int>("Beer");

                    b.Property<int>("Bread");

                    b.Property<int>("Butter");

                    b.Property<string>("Cat");

                    b.Property<int>("Cheese");

                    b.Property<int>("Coffee");

                    b.Property<DateTime>("DateState");

                    b.Property<int>("DietSoda");

                    b.Property<int>("Eggs");

                    b.Property<int>("Fish");

                    b.Property<int>("Fruit");

                    b.Property<int>("Juice");

                    b.Property<int>("Liquor");

                    b.Property<string>("Location");

                    b.Property<int>("Meat");

                    b.Property<int>("MyProperty");

                    b.Property<string>("Notes");

                    b.Property<int>("Nuts");

                    b.Property<int>("Oils");

                    b.Property<string>("OwnerID");

                    b.Property<int>("Pasta");

                    b.Property<int>("Potatoes");

                    b.Property<int>("Rice");

                    b.Property<int>("Soda");

                    b.Property<int>("Sweats");

                    b.Property<string>("Type");

                    b.Property<int>("Vegetable");

                    b.Property<int>("Water");

                    b.Property<int>("Wine");

                    b.Property<int>("Yogurt");

                    b.HasKey("ID");

                    b.ToTable("Consumings");
                });

            modelBuilder.Entity("BeingBeing.Models.EmotionalStates", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("EmotionalStates");
                });

            modelBuilder.Entity("BeingBeing.Models.Exercise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<int>("Duration");

                    b.Property<string>("Intensity");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("BeingBeing.Models.Pills", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Dose");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Pills");
                });

            modelBuilder.Entity("BeingBeing.Models.Poop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<string>("Color");

                    b.Property<string>("Density");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Poop");
                });

            modelBuilder.Entity("BeingBeing.Models.Sickness", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Sickness");
                });

            modelBuilder.Entity("BeingBeing.Models.Sleep", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<int>("Duration");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.Property<DateTime>("WentDown");

                    b.Property<DateTime>("WokeUp");

                    b.HasKey("ID");

                    b.ToTable("Sleep");
                });

            modelBuilder.Entity("BeingBeing.Models.Social", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.Property<string>("Where");

                    b.Property<string>("With");

                    b.HasKey("ID");

                    b.ToTable("Social");
                });

            modelBuilder.Entity("BeingBeing.Models.Stats", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Arms");

                    b.Property<int>("BodyFat");

                    b.Property<string>("Cat");

                    b.Property<int>("Chest");

                    b.Property<DateTime>("DateState");

                    b.Property<int>("Diastolic");

                    b.Property<int>("HDL");

                    b.Property<int>("Height");

                    b.Property<int>("LDL");

                    b.Property<int>("Legs");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<int>("Systolic");

                    b.Property<int>("VLDL");

                    b.Property<int>("Waist");

                    b.Property<int>("Weight");

                    b.HasKey("ID");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("BeingBeing.Models.Weather", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<string>("Description");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Temperature");

                    b.HasKey("ID");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("BeingBeing.Models.Working", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cat");

                    b.Property<DateTime>("DateState");

                    b.Property<int>("Duration");

                    b.Property<string>("Notes");

                    b.Property<string>("OwnerID");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Working");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BeingBeing.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BeingBeing.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeingBeing.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BeingBeing.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
