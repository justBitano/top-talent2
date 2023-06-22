using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TopTalentWebClient1.Models
{
    public partial class TopTalent2Context : DbContext
    {
        public TopTalent2Context()
        {
        }

        public TopTalent2Context(DbContextOptions<TopTalent2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<RefershTokenUser> RefershTokenUsers { get; set; }
        public virtual DbSet<RefreshTokenTalent> RefreshTokenTalents { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Talent> Talents { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-N2D8IS4\\SQLEXPRESS;Database=TopTalent2;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.Cash).HasColumnName("cash");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.TalentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Talent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_User");
            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TalentId });

                entity.ToTable("Chat");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("message");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.TalentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Talent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_User");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId)
                    .ValueGeneratedNever()
                    .HasColumnName("payment_id");

                entity.Property(e => e.Ammount).HasColumnName("ammount");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .HasColumnName("method");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Booking");
            });

            modelBuilder.Entity<RefershTokenUser>(entity =>
            {
                entity.HasKey(e => e.RefershToken);

                entity.ToTable("RefershTokenUser");

                entity.Property(e => e.RefershToken)
                    .ValueGeneratedNever()
                    .HasColumnName("refersh_token");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expiredAt");

                entity.Property(e => e.IsRevoked).HasColumnName("isRevoked");

                entity.Property(e => e.IsUsed).HasColumnName("isUsed");

                entity.Property(e => e.IssuedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("issuedAt");

                entity.Property(e => e.JwtId)
                    .HasMaxLength(1000)
                    .HasColumnName("jwtId");

                entity.Property(e => e.Token)
                    .HasMaxLength(1000)
                    .HasColumnName("token");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefershTokenUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RefershTokenUser_User");
            });

            modelBuilder.Entity<RefreshTokenTalent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RefreshTokenTalent");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expiredAt");

                entity.Property(e => e.IsRevoked).HasColumnName("isRevoked");

                entity.Property(e => e.IsUsed).HasColumnName("isUsed");

                entity.Property(e => e.IssuedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("issuedAt");

                entity.Property(e => e.JwtId)
                    .HasMaxLength(1000)
                    .HasColumnName("jwtId");

                entity.Property(e => e.RefreshTokenTalentId).HasColumnName("refresh_token_talent_id");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.Property(e => e.Token)
                    .HasMaxLength(1000)
                    .HasColumnName("token");

                entity.HasOne(d => d.Talent)
                    .WithMany()
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_RefreshTokenTalent_Talent");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.BookingId).HasColumnName("booking_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .HasColumnName("text");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Review_Booking");
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.ToTable("Talent");

                entity.Property(e => e.TalentId).HasColumnName("talent_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("address");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .HasColumnName("jobTitle");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
