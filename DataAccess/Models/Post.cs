using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Post
{
    public ulong Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string Title { get; set; } = null!;

    public string? Img { get; set; }

    public string? Description { get; set; }

    public ulong UserId { get; set; }

    public ulong CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
