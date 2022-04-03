﻿using System.ComponentModel.DataAnnotations;

namespace TimMovie.Core.Entities;

public class Film
{
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Title { get; set; }
    
    public DateTime Date { get; set; }
    
    public string? Description { get; set; }
    
    public Country? Country { get; set; }
    
    public string? Image { get; set; }
    
    public string? FilmLink { get; set; }
    
    public List<Comment> Comments { get; set; }

    public List<Producer> Producers { get; set; }

    public List<Actor> Actors { get; set; }

    public List<Genre> Genres { get; set; }
    public List<User> UsersWatchLater { get; set; }
    public List<User> UsersWatching { get; set; }
    
    public List<Subscribe> Subscribes { get; set; } 
}