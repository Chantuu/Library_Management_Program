using System;
using System.Collections.Generic;

namespace LibraryManagement.Infrastructure.Entities;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? AuthorId { get; set; }

    public int? GenreId { get; set; }

    public string? PublishDate { get; set; }

    public double? Rating { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Genre? Genre { get; set; }
}
