﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TS.DAL;

namespace TS.DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TS.DTO.Classes.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int?>("RelatorioVendaId");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("RelatorioVendaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TS.DTO.Classes.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Status");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("TS.DTO.Classes.RelatorioVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.ToTable("Relatorios");
                });

            modelBuilder.Entity("TS.DTO.Classes.Sessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("Data");

                    b.Property<int?>("FormaPagamentoId");

                    b.Property<decimal>("Preco");

                    b.Property<int?>("RelatorioVendaId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("RelatorioVendaId");

                    b.ToTable("Sessoes");
                });

            modelBuilder.Entity("TS.DTO.Classes.TipoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("TipoUsuarios");
                });

            modelBuilder.Entity("TS.DTO.Classes.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Senha");

                    b.Property<int?>("TipoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TS.DTO.Classes.Cliente", b =>
                {
                    b.HasOne("TS.DTO.Classes.RelatorioVenda")
                        .WithMany("Clientes")
                        .HasForeignKey("RelatorioVendaId");
                });

            modelBuilder.Entity("TS.DTO.Classes.Sessao", b =>
                {
                    b.HasOne("TS.DTO.Classes.Cliente", "Cliente")
                        .WithMany("Sessoes")
                        .HasForeignKey("ClienteId");

                    b.HasOne("TS.DTO.Classes.Pagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId");

                    b.HasOne("TS.DTO.Classes.RelatorioVenda")
                        .WithMany("Sessoes")
                        .HasForeignKey("RelatorioVendaId");
                });

            modelBuilder.Entity("TS.DTO.Classes.Usuario", b =>
                {
                    b.HasOne("TS.DTO.Classes.TipoUsuario", "Tipo")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoId");
                });
#pragma warning restore 612, 618
        }
    }
}