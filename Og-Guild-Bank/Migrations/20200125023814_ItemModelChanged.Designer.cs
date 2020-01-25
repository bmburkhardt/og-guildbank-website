﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Og_Guild_Bank.Models;

namespace Og_Guild_Bank.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200125023814_ItemModelChanged")]
    partial class ItemModelChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Og_Guild_Bank.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContainerId");

                    b.Property<int>("NumberSlots");

                    b.HasKey("Id");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("Og_Guild_Bank.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BagSlot");

                    b.Property<int>("ContainerId");

                    b.Property<string>("Image");

                    b.Property<int>("ItemCd");

                    b.Property<string>("ItemName");

                    b.Property<int>("ItemQuality");

                    b.Property<int>("ItemQuantity");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
