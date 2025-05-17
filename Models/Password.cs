namespace HashWarden;

public partial class Password
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int? FolderId { get; set; }

    public string? Title { get; set; }

    public string ServiceName { get; set; } = null!;

    public byte[] EncryptedPassword { get; set; } = null!;

    public byte[] Iv { get; set; } = null!;

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public virtual Folder? Folder { get; set; }

    public virtual User User { get; set; } = null!;
}
