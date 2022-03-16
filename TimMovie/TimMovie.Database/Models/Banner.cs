﻿using System.ComponentModel.DataAnnotations;

namespace TimMovie.Database.Models;

public class Banner
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    
    [Required]
    public Film Film { get; set; }
}