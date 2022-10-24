﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaComercioLibrary.Persistence.Context;

namespace SistemaComercioLibrary.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220921230157_item compra tabela")]
    partial class itemcompratabela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaComercioBiblioteca.Classes.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("Quantidade_Estoque")
                        .HasColumnType("int");

                    b.Property<int>("Unidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Saldo")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("int");

                    b.Property<string>("Situacao_Compra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total_Compra")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Lancamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Pagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("int");

                    b.Property<double>("Pago")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<double>("Valor_Pagamento")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("ContaPagar");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaReceber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Lancamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Recebimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<double>("Recebido")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<double>("Valor_Recebimento")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("ContaReceber");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.MovimentoCaixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Movimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Hora_Movimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Caixa")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_Movimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Caixa");

                    b.ToTable("MovimentoCaixa");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<string>("Situacao_Venda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total_Venda")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.Adm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adm");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.FormaPagamentoVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_FormaPagamento")
                        .HasColumnType("int");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_FormaPagamento");

                    b.HasIndex("Id_Venda");

                    b.ToTable("FormaPagamentoVenda");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Compra")
                        .HasColumnType("int");

                    b.Property<int>("Id_Produto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Compra");

                    b.HasIndex("Id_Produto");

                    b.ToTable("ItemCompra");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Produto")
                        .HasColumnType("int");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Produto");

                    b.HasIndex("Id_Venda");

                    b.ToTable("ItemVenda");
                });

            modelBuilder.Entity("SistemaComercioBiblioteca.Classes.Produto", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("Produto")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Compra", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("Compra")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaPagar", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("ContaPagar")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaReceber", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Cliente", "Cliente")
                        .WithMany("ContaReceber")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.MovimentoCaixa", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Caixa", "Caixa")
                        .WithMany("MovimentoCaixa")
                        .HasForeignKey("Id_Caixa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Venda", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Cliente", "Cliente")
                        .WithMany("Venda")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.FormaPagamentoVenda", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.FormaPagamento", "FormaPagamento")
                        .WithMany("FormaPagamentoVenda")
                        .HasForeignKey("Id_FormaPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioLibrary.Classes.Venda", "Venda")
                        .WithMany("FormaPagamentoVenda")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemCompra", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Compra", "Compra")
                        .WithMany("ItemCompra")
                        .HasForeignKey("Id_Compra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioBiblioteca.Classes.Produto", "Produto")
                        .WithMany("ItemCompra")
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemVenda", b =>
                {
                    b.HasOne("SistemaComercioBiblioteca.Classes.Produto", "Produto")
                        .WithMany("ItemVenda")
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioLibrary.Classes.Venda", "Venda")
                        .WithMany("ItemVenda")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
