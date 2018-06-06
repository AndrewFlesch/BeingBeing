﻿// <auto-generated />
using BeingBeing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BeingBeing.Migrations
{
    [DbContext(typeof(BeingBeingContext))]
    [Migration("20180606142403_typo")]
    partial class typo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeingBeing.Models.Appetite", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Appetite");
                });

            modelBuilder.Entity("BeingBeing.Models.Consuming", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Beans");

                    b.Property<int>("Beer");

                    b.Property<int>("Bread");

                    b.Property<int>("Butter");

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

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("EmotionalStates");
                });

            modelBuilder.Entity("BeingBeing.Models.Exercise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateState");

                    b.Property<int>("Duration");

                    b.Property<string>("Intensity");

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("BeingBeing.Models.Poop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Density");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Poop");
                });

            modelBuilder.Entity("BeingBeing.Models.Sickness", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateState");

                    b.Property<string>("Location");

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Sickness");
                });

            modelBuilder.Entity("BeingBeing.Models.Sleep", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Duration");

                    b.Property<string>("Quality");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Sleep");
                });

            modelBuilder.Entity("BeingBeing.Models.Social", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateState");

                    b.Property<int>("Duration");

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.Property<string>("Where");

                    b.HasKey("ID");

                    b.ToTable("Social");
                });

            modelBuilder.Entity("BeingBeing.Models.Weather", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Temperature");

                    b.HasKey("ID");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("BeingBeing.Models.Working", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateState");

                    b.Property<int>("Duration");

                    b.Property<string>("Notes");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Working");
                });
#pragma warning restore 612, 618
        }
    }
}
