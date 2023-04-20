﻿// <auto-generated />
using FilmSystem.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Film_System.Migrations
{
    [DbContext(typeof(FilmSystemDbContext))]
    [Migration("20230420101724_AddNewColumnToGenreTable")]
    partial class AddNewColumnToGenreTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FilmSystem.Models.Genre", b =>
                {
                    b.Property<int>("Id_genre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_genre"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Id_tmdb")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id_genre");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("FilmSystem.Models.Movie", b =>
                {
                    b.Property<int>("Id_movie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_movie"), 1L, 1);

                    b.Property<int>("Fk_person")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_movie");

                    b.HasIndex("Fk_person");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("FilmSystem.Models.MovieGenre", b =>
                {
                    b.Property<int>("Id_movieGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_movieGenre"), 1L, 1);

                    b.Property<int>("Fk_genre")
                        .HasColumnType("int");

                    b.Property<int>("Fk_movie")
                        .HasColumnType("int");

                    b.HasKey("Id_movieGenre");

                    b.HasIndex("Fk_genre");

                    b.HasIndex("Fk_movie");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("FilmSystem.Models.MovieRating", b =>
                {
                    b.Property<int>("Id_movieRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_movieRating"), 1L, 1);

                    b.Property<int>("Fk_movie")
                        .HasColumnType("int");

                    b.Property<int>("Fk_person")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id_movieRating");

                    b.HasIndex("Fk_movie");

                    b.HasIndex("Fk_person");

                    b.ToTable("MovieRating");
                });

            modelBuilder.Entity("FilmSystem.Models.Person", b =>
                {
                    b.Property<int>("Id_person")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_person"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id_person");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("FilmSystem.Models.PersonGenre", b =>
                {
                    b.Property<int>("Id_personGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_personGenre"), 1L, 1);

                    b.Property<int>("Fk_genre")
                        .HasColumnType("int");

                    b.Property<int>("Fk_person")
                        .HasColumnType("int");

                    b.HasKey("Id_personGenre");

                    b.HasIndex("Fk_genre");

                    b.HasIndex("Fk_person");

                    b.ToTable("PersonGenre");
                });

            modelBuilder.Entity("FilmSystem.Models.Movie", b =>
                {
                    b.HasOne("FilmSystem.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Fk_person")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("FilmSystem.Models.MovieGenre", b =>
                {
                    b.HasOne("FilmSystem.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("Fk_genre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmSystem.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("Fk_movie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("FilmSystem.Models.MovieRating", b =>
                {
                    b.HasOne("FilmSystem.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("Fk_movie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmSystem.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Fk_person")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("FilmSystem.Models.PersonGenre", b =>
                {
                    b.HasOne("FilmSystem.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("Fk_genre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilmSystem.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Fk_person")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
