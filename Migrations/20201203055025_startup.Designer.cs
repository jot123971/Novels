﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Novels.Data;

namespace Novels.Migrations
{
    [DbContext(typeof(NovelsContext))]
    [Migration("20201203055025_startup")]
    partial class startup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Novels.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NovelId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId");

                    b.HasIndex("NovelId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Novels.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreOfNovel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Novels.Models.Novel", b =>
                {
                    b.Property<int>("NovelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFamous")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Review")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NovelId");

                    b.HasIndex("GenreId");

                    b.ToTable("Novel");
                });

            modelBuilder.Entity("Novels.Models.NovelAuthor", b =>
                {
                    b.Property<int>("NovelAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("NovelId")
                        .HasColumnType("int");

                    b.HasKey("NovelAuthorId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("NovelId");

                    b.ToTable("NovelAuthor");
                });

            modelBuilder.Entity("Novels.Models.Author", b =>
                {
                    b.HasOne("Novels.Models.Novel", null)
                        .WithMany("Authors")
                        .HasForeignKey("NovelId");
                });

            modelBuilder.Entity("Novels.Models.Novel", b =>
                {
                    b.HasOne("Novels.Models.Genre", "Genres")
                        .WithMany("Novels")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Novels.Models.NovelAuthor", b =>
                {
                    b.HasOne("Novels.Models.Author", "Authors")
                        .WithMany("NovelAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Novels.Models.Novel", "Novels")
                        .WithMany()
                        .HasForeignKey("NovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
