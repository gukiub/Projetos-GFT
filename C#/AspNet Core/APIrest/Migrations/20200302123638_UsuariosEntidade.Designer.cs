﻿// <auto-generated />
using APIrest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIrest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200302123638_UsuariosEntidade")]
    partial class UsuariosEntidade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIrest.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("APIrest.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
