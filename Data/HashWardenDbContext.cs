using HashWarden.Helpers;
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

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<Password> Passwords { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string? connectionString = AppConfiguration.GetConnectionString();
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show("Brak poprawnego connection stringa w pliku konfiguracyjnym.", "Błąd połączenia",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            optionsBuilder.UseNpgsql(connectionString);
        }
    }

    public void RefreshConnectionString()
    {
        var connectionString = AppConfiguration.GetConnectionString();
        if (!string.IsNullOrWhiteSpace(connectionString))
        {
            this.Database.SetConnectionString(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.HasKey(u => u.Id);

            entity.Property(u => u.Id)
                  .HasColumnName("id");

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
                  .HasColumnType("date");

            entity.HasIndex(u => u.Email)
                  .IsUnique()
                  .HasDatabaseName("users_email_key");
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.ToTable("folders");

            entity.HasKey(f => f.Id);

            entity.Property(f => f.Id)
                  .HasColumnName("id");

            entity.Property(f => f.FolderName)
                  .HasColumnName("folder_name")
                  .HasMaxLength(50)
                  .IsRequired();

            entity.Property(f => f.UserId)
                  .HasColumnName("user_id");

            entity.HasOne(f => f.User)
                  .WithMany(u => u.Folders)
                  .HasForeignKey(f => f.UserId)
                  .HasConstraintName("folders_user_id_fkey")
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Password>(entity =>
        {
            entity.ToTable("passwords");

            entity.HasKey(p => p.Id);

            entity.Property(p => p.Id)
                  .HasColumnName("id");

            entity.Property(p => p.Title)
                  .HasColumnName("title")
                  .HasMaxLength(40);

            entity.Property(p => p.UserName)
                  .HasColumnName("user_name")
                  .HasMaxLength(40)
                  .IsRequired();

            entity.Property(p => p.ServiceUrl)
                  .HasColumnName("service_url")
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
                  .HasColumnType("date");

            entity.Property(p => p.UpdatedAt)
                  .HasColumnName("updated_at")
                  .HasColumnType("date");

            entity.HasOne(p => p.User)
                  .WithMany(u => u.Passwords)
                  .HasForeignKey(p => p.UserId)
                  .HasConstraintName("passwords_user_id_fkey")
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(p => p.Folder)
                  .WithMany(f => f.Passwords)
                  .HasForeignKey(p => p.FolderId)
                  .HasConstraintName("passwords_folder_id_fkey")
                  .OnDelete(DeleteBehavior.SetNull);
        });
    }
}