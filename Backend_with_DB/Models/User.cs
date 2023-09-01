using System;
using System.Collections.Generic;

namespace Backend_with_DB.Models;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedOn { get; set; }
}
