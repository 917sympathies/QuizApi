﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Quiz.Infrastructure.Models;

#nullable disable

namespace Quiz.Api.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GameUserDtoToDb", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PlayersId")
                        .HasColumnType("uuid");

                    b.HasKey("GameId", "PlayersId");

                    b.HasIndex("PlayersId");

                    b.ToTable("GameUserDtoToDb");
                });

            modelBuilder.Entity("Quiz.Domain.DTO.UserDtoToDb", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("QuestionPackId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Visibility")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.GameResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("GameResult");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("QuestionPackId")
                        .HasColumnType("uuid");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("QuestionPackId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.QuestionPack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QuestionPacks");
                });

            modelBuilder.Entity("UserDtoToDbUserDtoToDb", b =>
                {
                    b.Property<Guid>("FriendsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserDtoToDbId")
                        .HasColumnType("uuid");

                    b.HasKey("FriendsId", "UserDtoToDbId");

                    b.HasIndex("UserDtoToDbId");

                    b.ToTable("UserDtoToDbUserDtoToDb");
                });

            modelBuilder.Entity("GameUserDtoToDb", b =>
                {
                    b.HasOne("Quiz.Domain.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quiz.Domain.DTO.UserDtoToDb", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Quiz.Domain.Entities.GameResult", b =>
                {
                    b.HasOne("Quiz.Domain.Entities.Game", null)
                        .WithMany("Results")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Option", b =>
                {
                    b.HasOne("Quiz.Domain.Entities.Question", null)
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Question", b =>
                {
                    b.HasOne("Quiz.Domain.Entities.QuestionPack", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuestionPackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserDtoToDbUserDtoToDb", b =>
                {
                    b.HasOne("Quiz.Domain.DTO.UserDtoToDb", null)
                        .WithMany()
                        .HasForeignKey("FriendsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quiz.Domain.DTO.UserDtoToDb", null)
                        .WithMany()
                        .HasForeignKey("UserDtoToDbId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Game", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("Quiz.Domain.Entities.QuestionPack", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}