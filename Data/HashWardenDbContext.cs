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
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("folders_pkey");

            entity.ToTable("folders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FolderName)
                .HasMaxLength(50)
                .HasColumnName("folder_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Folders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("folders_user_id_fkey");
        });

        modelBuilder.Entity<Password>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("passwords_pkey");

            entity.ToTable("passwords");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.EncryptedPassword).HasColumnName("encrypted_password");
            entity.Property(e => e.FolderId).HasColumnName("folder_id");
            entity.Property(e => e.Iv).HasColumnName("iv");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(40)
                .HasColumnName("service_name");
            entity.Property(e => e.Title)
                .HasMaxLength(40)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Folder).WithMany(p => p.Passwords)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("passwords_folder_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Passwords)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("passwords_user_id_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "users_email_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.MasterHash).HasColumnName("master_hash");
            entity.Property(e => e.Salt).HasColumnName("salt");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("email");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
