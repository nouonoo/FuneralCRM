using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Patronymic { get; set; }

    public byte[] PasswordHash { get; set; } = null!;

    public int RoleId { get; set; }

    public string? Avatar { get; set; }

    public virtual UserRole Role { get; set; } = null!;
}
