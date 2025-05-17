namespace HashWarden;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public byte[] MasterHash { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;
    public byte[] Iv { get; set; } = null!;

    public DateOnly? CreatedAt { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<Password> Passwords { get; set; } = new List<Password>();
}
