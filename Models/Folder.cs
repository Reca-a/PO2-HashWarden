using System;
using System.Collections.Generic;

namespace HashWarden;

public partial class Folder
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string FolderName { get; set; } = null!;

    public virtual ICollection<Password> Passwords { get; set; } = new List<Password>();

    public virtual User User { get; set; } = null!;
}
