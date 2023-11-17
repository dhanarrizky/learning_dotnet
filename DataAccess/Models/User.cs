using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class User
{
    public ulong Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long Phone { get; set; }

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool? Gender { get; set; }

    public string Token { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public string BirthPlace { get; set; } = null!;

    public string Birth { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string? Address { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; } = new List<Post>();
}
