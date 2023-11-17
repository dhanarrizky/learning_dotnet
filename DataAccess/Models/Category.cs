using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Category
{
    public ulong Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; } = new List<Post>();
}
