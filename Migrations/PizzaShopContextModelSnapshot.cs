﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaShop.Data;

namespace PizzaShop.Migrations
{
    [DbContext(typeof(PizzaShopContext))]
    partial class PizzaShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaShop.ProtoTypes.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PizzaShop.ProtoTypes.Order", b =>
                {
                    b.Property<int>("OrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerCustId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderNumber");

                    b.HasIndex("CustomerCustId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaShop.ProtoTypes.Pizza", b =>
                {
                    b.Property<int>("PizzaCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSpicy")
                        .HasColumnType("bit");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("PizzaCode");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaShop.ProtoTypes.PizzaOrder", b =>
                {
                    b.Property<int>("PizzaOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("PizzaCode")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PizzaOrderId");

                    b.HasIndex("OrderNumber");

                    b.HasIndex("PizzaCode");

                    b.ToTable("PizzaOrder");
                });

            modelBuilder.Entity("PizzaShop.ProtoTypes.Order", b =>
                {
                    b.HasOne("PizzaShop.ProtoTypes.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerCustId");
                });

            modelBuilder.Entity("PizzaShop.ProtoTypes.PizzaOrder", b =>
                {
                    b.HasOne("PizzaShop.ProtoTypes.Order", "Order")
                        .WithMany("PizzaOrder")
                        .HasForeignKey("OrderNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaShop.ProtoTypes.Pizza", "Pizza")
                        .WithMany("PizzaOrder")
                        .HasForeignKey("PizzaCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}