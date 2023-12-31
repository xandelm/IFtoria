﻿// <auto-generated />
using System;
using IFToria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IFToria.Migrations
{
    [DbContext(typeof(AlunoDbContext))]
    partial class AlunoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("IFToria.Data.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("CursoMatriculado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TutoriaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TutoriaId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("IFToria.Data.Tutoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Certificado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Disciplina")
                        .HasColumnType("TEXT");

                    b.Property<int>("Duracao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TutorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vagas")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Tutoria");
                });

            modelBuilder.Entity("IFToria.Data.Aluno", b =>
                {
                    b.HasOne("IFToria.Data.Tutoria", null)
                        .WithMany("Inscritos")
                        .HasForeignKey("TutoriaId");
                });

            modelBuilder.Entity("IFToria.Data.Tutoria", b =>
                {
                    b.HasOne("IFToria.Data.Aluno", "Tutor")
                        .WithMany("Tutorias")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("IFToria.Data.Aluno", b =>
                {
                    b.Navigation("Tutorias");
                });

            modelBuilder.Entity("IFToria.Data.Tutoria", b =>
                {
                    b.Navigation("Inscritos");
                });
#pragma warning restore 612, 618
        }
    }
}
