﻿// <auto-generated />
using GerenciadorAmbev.ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciadorAmbev.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240719170809_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Conta")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Professor", (string)null);
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("IdProfessor")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("IdProfessor");

                    b.ToTable("Turma", (string)null);
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.TurmaAluno", b =>
                {
                    b.Property<int>("IdTurma")
                        .HasColumnType("int");

                    b.Property<int>("IdAluno")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("IdTurma", "IdAluno");

                    b.HasIndex("IdAluno");

                    b.ToTable("TurmaAluno", (string)null);
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Turma", b =>
                {
                    b.HasOne("GerenciadorAmbev.Domain.Model.Professor", "Professor")
                        .WithMany("Turmas")
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.TurmaAluno", b =>
                {
                    b.HasOne("GerenciadorAmbev.Domain.Model.Aluno", "Aluno")
                        .WithMany("TurmaAluno")
                        .HasForeignKey("IdAluno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorAmbev.Domain.Model.Turma", "Turma")
                        .WithMany("TurmaAlunos")
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Aluno", b =>
                {
                    b.Navigation("TurmaAluno");
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Professor", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("GerenciadorAmbev.Domain.Model.Turma", b =>
                {
                    b.Navigation("TurmaAlunos");
                });
#pragma warning restore 612, 618
        }
    }
}