using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HashWarden.Data;

public partial class HashWardenDbContext : DbContext
{
    public HashWardenDbContext()
    {
    }

    public HashWardenDbContext(DbContextOptions<HashWardenDbContext> options)
        : base(options)
    {
    }

    public static IConfiguration LoadConfiguration()
    {
        try
        {
            string baseDirectory = AppContext.BaseDirectory;
            string configPath = Path.Combine(baseDirectory, "appsettings.json");

            if (!File.Exists(configPath))
            {
                string projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", ".."));
                configPath = Path.Combine(projectDirectory, "appsettings.json");

                if (!File.Exists(configPath))
                {
                    throw new FileNotFoundException($"Nie znaleziono pliku appsettings.json w ścieżkach:\n" +
                        $"- {Path.Combine(baseDirectory, "appsettings.json")}\n" +
                        $"- {configPath}");
                }
            }
            return new ConfigurationBuilder()
                .AddJsonFile(configPath, optional: false, reloadOnChange: true)
                .Build();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Błąd podczas wczytywania konfiguracji: {ex.Message}", "Błąd konfiguracji",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<Password> Passwords { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = LoadConfiguration();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.HasKey(u => u.Id);

            entity.Property(u => u.Email)
                  .HasColumnName("email")
                  .HasMaxLength(40)
                  .IsRequired();

            entity.Property(u => u.Salt)
                  .HasColumnName("salt")
                  .IsRequired();

            entity.Property(u => u.Iv)
                  .HasColumnName("iv")
                  .IsRequired();

            entity.Property(u => u.MasterHash)
                  .HasColumnName("master_hash")
                  .IsRequired();

            entity.Property(u => u.CreatedAt)
                  .HasColumnName("created_at")
                  .HasColumnType("date")
                  .HasDefaultValueSql("null");

            entity.HasIndex(u => u.Email)
                  .IsUnique()
                  .HasDatabaseName("users_email_key");
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.ToTable("folders");

            entity.HasKey(f => f.Id);

            entity.Property(f => f.FolderName)
                  .HasColumnName("folder_name")
                  .HasMaxLength(50)
                  .IsRequired();

            entity.Property(f => f.UserId)
                  .HasColumnName("user_id");

            entity.HasOne(u => u.User)
                  .WithMany(f => f.Folders)
                  .HasForeignKey(u => u.UserId)
                  .HasConstraintName("folders_user_id_fkey")
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Password>(entity =>
        {
            entity.ToTable("passwords");

            entity.HasKey(p => p.Id);

            entity.Property(p => p.Title)
                  .HasColumnName("title")
                  .HasMaxLength(40)
                  .IsRequired();

            entity.Property(p => p.ServiceName)
                  .HasColumnName("service_name")
                  .HasMaxLength(40)
                  .IsRequired();

            entity.Property(p => p.EncryptedPassword)
                  .HasColumnName("encrypted_password")
                  .IsRequired();

            entity.Property(p => p.Iv)
                  .HasColumnName("iv")
                  .IsRequired();

            entity.Property(p => p.UserId)
                  .HasColumnName("user_id");

            entity.Property(p => p.FolderId)
                  .HasColumnName("folder_id");

            entity.Property(p => p.CreatedAt)
                  .HasColumnName("created_at")
                  .HasColumnType("date")
                  .HasDefaultValueSql("null");

            entity.Property(p => p.UpdatedAt)
                  .HasColumnName("updated_at")
                  .HasColumnType("date")
                  .HasDefaultValueSql("null");

            entity.HasOne(u => u.User)
                  .WithMany(p => p.Passwords)
                  .HasForeignKey(u => u.UserId)
                  .HasConstraintName("passwords_user_id_fkey")
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(f => f.Folder)
                  .WithMany(p => p.Passwords)
                  .HasForeignKey(f => f.FolderId)
                  .HasConstraintName("passwords_folder_id_fkey")
                  .OnDelete(DeleteBehavior.SetNull);
        });
    }
}
