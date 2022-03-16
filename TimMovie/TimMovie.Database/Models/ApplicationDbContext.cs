﻿using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TimMovie.Database.Models;

public class ApplicationContext : IdentityDbContext<User,IdentityRole<int>,int>
{
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<CommentReport> CommentReports { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Subscribe> Subscribes { get; set; }
    public DbSet<UserFilmWatched> WatchedFilms { get; set; }
    public DbSet<UserSubscribe> UserSubscribes { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasMany(x => x.FilmsWatchLater).WithMany(x => x.UsersWatchLater);
        modelBuilder.Entity<User>().HasOne(x => x.WatchingFilm).WithMany(x => x.UsersWatching);

    }
}