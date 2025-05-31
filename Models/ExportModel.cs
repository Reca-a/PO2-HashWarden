namespace HashWarden.Models
{
    public class ExportModel
    {
        public List<string> Folders { get; set; } = new();
        public List<ExportPassword> Passwords { get; set; } = new();
    }

    public class ExportPassword
    {
        public string? Title { get; set; }
        public string UserName { get; set; } = null!;
        public string ServiceUrl { get; set; } = null!;
        public string EncryptedPassword { get; set; } = null!;
        public string Iv { get; set; } = null!;
        public string? FolderName { get; set; }
        public DateOnly? CreatedAt { get; set; }
        public DateOnly? UpdatedAt { get; set; }
    }
}
