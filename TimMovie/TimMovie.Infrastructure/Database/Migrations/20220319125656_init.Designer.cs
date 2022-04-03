﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TimMovie.Infrastructure.Database.Migrations;

[DbContext(typeof(ApplicationContext))]
[Migration("20220319125656_init")]
partial class init
{
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 63);

        NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

        modelBuilder.Entity("ActorFilm", b =>
        {
            b.Property<Guid>("ActorsId")
                .HasColumnType("uuid");

            b.Property<Guid>("FilmsId")
                .HasColumnType("uuid");

            b.HasKey("ActorsId", "FilmsId");

            b.HasIndex("FilmsId");

            b.ToTable("ActorFilm");
        });

        modelBuilder.Entity("FilmGenre", b =>
        {
            b.Property<Guid>("FilmsId")
                .HasColumnType("uuid");

            b.Property<Guid>("GenresId")
                .HasColumnType("uuid");

            b.HasKey("FilmsId", "GenresId");

            b.HasIndex("GenresId");

            b.ToTable("FilmGenre");
        });

        modelBuilder.Entity("FilmProducer", b =>
        {
            b.Property<Guid>("FilmsId")
                .HasColumnType("uuid");

            b.Property<Guid>("ProducersId")
                .HasColumnType("uuid");

            b.HasKey("FilmsId", "ProducersId");

            b.HasIndex("ProducersId");

            b.ToTable("FilmProducer");
        });

        modelBuilder.Entity("FilmSubscribe", b =>
        {
            b.Property<Guid>("FilmsId")
                .HasColumnType("uuid");

            b.Property<Guid>("SubscribesId")
                .HasColumnType("uuid");

            b.HasKey("FilmsId", "SubscribesId");

            b.HasIndex("SubscribesId");

            b.ToTable("FilmSubscribe");
        });

        modelBuilder.Entity("FilmUser", b =>
        {
            b.Property<Guid>("FilmsWatchLaterId")
                .HasColumnType("uuid");

            b.Property<Guid>("UsersWatchLaterId")
                .HasColumnType("uuid");

            b.HasKey("FilmsWatchLaterId", "UsersWatchLaterId");

            b.HasIndex("UsersWatchLaterId");

            b.ToTable("FilmUser");
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("ConcurrencyStamp")
                .IsConcurrencyToken()
                .HasColumnType("text");

            b.Property<string>("Name")
                .HasMaxLength(256)
                .HasColumnType("character varying(256)");

            b.Property<string>("NormalizedName")
                .HasMaxLength(256)
                .HasColumnType("character varying(256)");

            b.HasKey("Id");

            b.HasIndex("NormalizedName")
                .IsUnique()
                .HasDatabaseName("RoleNameIndex");

            b.ToTable("AspNetRoles", (string)null);
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<string>("ClaimType")
                .HasColumnType("text");

            b.Property<string>("ClaimValue")
                .HasColumnType("text");

            b.Property<Guid>("RoleId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("RoleId");

            b.ToTable("AspNetRoleClaims", (string)null);
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer");

            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

            b.Property<string>("ClaimType")
                .HasColumnType("text");

            b.Property<string>("ClaimValue")
                .HasColumnType("text");

            b.Property<Guid>("UserId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("AspNetUserClaims", (string)null);
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
        {
            b.Property<string>("LoginProvider")
                .HasColumnType("text");

            b.Property<string>("ProviderKey")
                .HasColumnType("text");

            b.Property<string>("ProviderDisplayName")
                .HasColumnType("text");

            b.Property<Guid>("UserId")
                .HasColumnType("uuid");

            b.HasKey("LoginProvider", "ProviderKey");

            b.HasIndex("UserId");

            b.ToTable("AspNetUserLogins", (string)null);
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
        {
            b.Property<Guid>("UserId")
                .HasColumnType("uuid");

            b.Property<Guid>("RoleId")
                .HasColumnType("uuid");

            b.HasKey("UserId", "RoleId");

            b.HasIndex("RoleId");

            b.ToTable("AspNetUserRoles", (string)null);
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
        {
            b.Property<Guid>("UserId")
                .HasColumnType("uuid");

            b.Property<string>("LoginProvider")
                .HasColumnType("text");

            b.Property<string>("Name")
                .HasColumnType("text");

            b.Property<string>("Value")
                .HasColumnType("text");

            b.HasKey("UserId", "LoginProvider", "Name");

            b.ToTable("AspNetUserTokens", (string)null);
        });

        modelBuilder.Entity("NotificationUser", b =>
        {
            b.Property<Guid>("NotificationsId")
                .HasColumnType("uuid");

            b.Property<Guid>("UsersId")
                .HasColumnType("uuid");

            b.HasKey("NotificationsId", "UsersId");

            b.HasIndex("UsersId");

            b.ToTable("NotificationUser");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Actor", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Name")
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("character varying(100)");

            b.Property<string>("Photo")
                .HasColumnType("text");

            b.Property<string>("Surname")
                .HasMaxLength(100)
                .HasColumnType("character varying(100)");

            b.HasKey("Id");

            b.ToTable("Actors");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Banner", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Description")
                .HasColumnType("text");

            b.Property<Guid>("FilmId")
                .HasColumnType("uuid");

            b.Property<string>("Image")
                .IsRequired()
                .HasColumnType("text");

            b.HasKey("Id");

            b.HasIndex("FilmId");

            b.ToTable("Banners");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Comment", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<Guid>("AuthorId")
                .HasColumnType("uuid");

            b.Property<string>("Content")
                .IsRequired()
                .HasColumnType("text");

            b.Property<DateTime>("Date")
                .HasColumnType("timestamp with time zone");

            b.Property<Guid>("FilmId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("AuthorId");

            b.HasIndex("FilmId");

            b.ToTable("Comments");
        });

        modelBuilder.Entity("TimMovie.Database.Models.CommentReport", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<Guid>("CommentId")
                .HasColumnType("uuid");

            b.Property<Guid>("UserId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("CommentId");

            b.HasIndex("UserId");

            b.ToTable("CommentReports");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Country", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Name")
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("character varying(100)");

            b.HasKey("Id");

            b.ToTable("Countries");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Film", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<Guid?>("CountryId")
                .HasColumnType("uuid");

            b.Property<DateTime>("Date")
                .HasColumnType("timestamp with time zone");

            b.Property<string>("Description")
                .HasColumnType("text");

            b.Property<string>("FilmLink")
                .HasColumnType("text");

            b.Property<string>("Image")
                .HasColumnType("text");

            b.Property<string>("Title")
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("character varying(200)");

            b.HasKey("Id");

            b.HasIndex("CountryId");

            b.ToTable("Films");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Genre", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Name")
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("character varying(50)");

            b.HasKey("Id");

            b.ToTable("Genres");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Notification", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Content")
                .IsRequired()
                .HasColumnType("text");

            b.Property<DateTime?>("Date")
                .HasColumnType("timestamp with time zone");

            b.HasKey("Id");

            b.ToTable("Notifications");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Producer", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Name")
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("character varying(100)");

            b.Property<string>("Photo")
                .HasColumnType("text");

            b.Property<string>("Surname")
                .HasMaxLength(100)
                .HasColumnType("character varying(100)");

            b.HasKey("Id");

            b.ToTable("Producers");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Subscribe", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<string>("Description")
                .HasColumnType("text");

            b.Property<string>("Name")
                .IsRequired()
                .HasMaxLength(70)
                .HasColumnType("character varying(70)");

            b.Property<float>("Price")
                .HasColumnType("real");

            b.HasKey("Id");

            b.ToTable("Subscribes");
        });

        modelBuilder.Entity("TimMovie.Database.Models.User", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<int>("AccessFailedCount")
                .HasColumnType("integer");

            b.Property<string>("ConcurrencyStamp")
                .IsConcurrencyToken()
                .HasColumnType("text");

            b.Property<Guid?>("CountryId")
                .HasColumnType("uuid");

            b.Property<string>("Email")
                .HasMaxLength(256)
                .HasColumnType("character varying(256)");

            b.Property<bool>("EmailConfirmed")
                .HasColumnType("boolean");

            b.Property<bool>("LockoutEnabled")
                .HasColumnType("boolean");

            b.Property<DateTimeOffset?>("LockoutEnd")
                .HasColumnType("timestamp with time zone");

            b.Property<string>("NormalizedEmail")
                .HasMaxLength(256)
                .HasColumnType("character varying(256)");

            b.Property<string>("NormalizedUserName")
                .HasMaxLength(256)
                .HasColumnType("character varying(256)");

            b.Property<string>("PasswordHash")
                .HasColumnType("text");

            b.Property<string>("PhoneNumber")
                .HasColumnType("text");

            b.Property<bool>("PhoneNumberConfirmed")
                .HasColumnType("boolean");

            b.Property<DateTime>("RegistrationDate")
                .HasColumnType("timestamp with time zone");

            b.Property<string>("SecurityStamp")
                .HasColumnType("text");

            b.Property<int>("Status")
                .HasColumnType("integer");

            b.Property<bool>("TwoFactorEnabled")
                .HasColumnType("boolean");

            b.Property<string>("UserName")
                .HasMaxLength(256)
                .HasColumnType("character varying(256)");

            b.Property<Guid?>("WatchingFilmId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("CountryId");

            b.HasIndex("NormalizedEmail")
                .HasDatabaseName("EmailIndex");

            b.HasIndex("NormalizedUserName")
                .IsUnique()
                .HasDatabaseName("UserNameIndex");

            b.HasIndex("WatchingFilmId");

            b.ToTable("AspNetUsers", (string)null);
        });

        modelBuilder.Entity("TimMovie.Database.Models.UserFilmWatched", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<DateTime>("Date")
                .HasColumnType("timestamp with time zone");

            b.Property<Guid>("FilmId")
                .HasColumnType("uuid");

            b.Property<int?>("Grade")
                .HasColumnType("integer");

            b.Property<Guid>("WatchedUserId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("FilmId");

            b.HasIndex("WatchedUserId");

            b.ToTable("WatchedFilms");
        });

        modelBuilder.Entity("TimMovie.Database.Models.UserSubscribe", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<DateTime>("EndDate")
                .HasColumnType("timestamp with time zone");

            b.Property<DateTime>("StartDay")
                .HasColumnType("timestamp with time zone");

            b.Property<Guid>("SubscribeId")
                .HasColumnType("uuid");

            b.Property<Guid>("SubscribedUserId")
                .HasColumnType("uuid");

            b.HasKey("Id");

            b.HasIndex("SubscribeId");

            b.HasIndex("SubscribedUserId");

            b.ToTable("UserSubscribes");
        });

        modelBuilder.Entity("ActorFilm", b =>
        {
            b.HasOne("TimMovie.Database.Models.Actor", null)
                .WithMany()
                .HasForeignKey("ActorsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.Film", null)
                .WithMany()
                .HasForeignKey("FilmsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("FilmGenre", b =>
        {
            b.HasOne("TimMovie.Database.Models.Film", null)
                .WithMany()
                .HasForeignKey("FilmsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.Genre", null)
                .WithMany()
                .HasForeignKey("GenresId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("FilmProducer", b =>
        {
            b.HasOne("TimMovie.Database.Models.Film", null)
                .WithMany()
                .HasForeignKey("FilmsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.Producer", null)
                .WithMany()
                .HasForeignKey("ProducersId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("FilmSubscribe", b =>
        {
            b.HasOne("TimMovie.Database.Models.Film", null)
                .WithMany()
                .HasForeignKey("FilmsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.Subscribe", null)
                .WithMany()
                .HasForeignKey("SubscribesId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("FilmUser", b =>
        {
            b.HasOne("TimMovie.Database.Models.Film", null)
                .WithMany()
                .HasForeignKey("FilmsWatchLaterId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.User", null)
                .WithMany()
                .HasForeignKey("UsersWatchLaterId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
        {
            b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                .WithMany()
                .HasForeignKey("RoleId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
        {
            b.HasOne("TimMovie.Database.Models.User", null)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
        {
            b.HasOne("TimMovie.Database.Models.User", null)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
        {
            b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                .WithMany()
                .HasForeignKey("RoleId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.User", null)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
        {
            b.HasOne("TimMovie.Database.Models.User", null)
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("NotificationUser", b =>
        {
            b.HasOne("TimMovie.Database.Models.Notification", null)
                .WithMany()
                .HasForeignKey("NotificationsId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.User", null)
                .WithMany()
                .HasForeignKey("UsersId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        });

        modelBuilder.Entity("TimMovie.Database.Models.Banner", b =>
        {
            b.HasOne("TimMovie.Database.Models.Film", "Film")
                .WithMany()
                .HasForeignKey("FilmId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Film");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Comment", b =>
        {
            b.HasOne("TimMovie.Database.Models.User", "Author")
                .WithMany()
                .HasForeignKey("AuthorId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.Film", "Film")
                .WithMany("Comments")
                .HasForeignKey("FilmId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Author");

            b.Navigation("Film");
        });

        modelBuilder.Entity("TimMovie.Database.Models.CommentReport", b =>
        {
            b.HasOne("TimMovie.Database.Models.Comment", "Comment")
                .WithMany()
                .HasForeignKey("CommentId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.User", "User")
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Comment");

            b.Navigation("User");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Film", b =>
        {
            b.HasOne("TimMovie.Database.Models.Country", "Country")
                .WithMany("Films")
                .HasForeignKey("CountryId")
                .OnDelete(DeleteBehavior.SetNull);

            b.Navigation("Country");
        });

        modelBuilder.Entity("TimMovie.Database.Models.User", b =>
        {
            b.HasOne("TimMovie.Database.Models.Country", "Country")
                .WithMany("Users")
                .HasForeignKey("CountryId")
                .OnDelete(DeleteBehavior.SetNull);

            b.HasOne("TimMovie.Database.Models.Film", "WatchingFilm")
                .WithMany("UsersWatching")
                .HasForeignKey("WatchingFilmId")
                .OnDelete(DeleteBehavior.SetNull);

            b.Navigation("Country");

            b.Navigation("WatchingFilm");
        });

        modelBuilder.Entity("TimMovie.Database.Models.UserFilmWatched", b =>
        {
            b.HasOne("TimMovie.Database.Models.Film", "Film")
                .WithMany()
                .HasForeignKey("FilmId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.User", "WatchedUser")
                .WithMany("WatchedFilms")
                .HasForeignKey("WatchedUserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Film");

            b.Navigation("WatchedUser");
        });

        modelBuilder.Entity("TimMovie.Database.Models.UserSubscribe", b =>
        {
            b.HasOne("TimMovie.Database.Models.Subscribe", "Subscribe")
                .WithMany()
                .HasForeignKey("SubscribeId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.HasOne("TimMovie.Database.Models.User", "SubscribedUser")
                .WithMany()
                .HasForeignKey("SubscribedUserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Subscribe");

            b.Navigation("SubscribedUser");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Country", b =>
        {
            b.Navigation("Films");

            b.Navigation("Users");
        });

        modelBuilder.Entity("TimMovie.Database.Models.Film", b =>
        {
            b.Navigation("Comments");

            b.Navigation("UsersWatching");
        });

        modelBuilder.Entity("TimMovie.Database.Models.User", b =>
        {
            b.Navigation("WatchedFilms");
        });
#pragma warning restore 612, 618
    }
}