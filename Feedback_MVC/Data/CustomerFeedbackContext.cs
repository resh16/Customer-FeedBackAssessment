using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Feedback_MVC.Models;

#nullable disable

namespace Feedback_MVC.Data
{
    public partial class CustomerFeedbackContext : DbContext
    {
        public CustomerFeedbackContext()
        {
        }

        public CustomerFeedbackContext(DbContextOptions<CustomerFeedbackContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<FeedBack> FeedBacks { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInfo> ProductInfos { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Unsatisfactory> Unsatisfactories { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=Trainee-07;Database=CustomerFeedback;User Id=SA;Password=Gislenpw16");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Category1).IsUnicode(false);
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__FeedBack__Produc__3E52440B");

                entity.HasOne(d => d.Unsatisfactory)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.UnsatisfactoryId)
                    .HasConstraintName("FK__FeedBack__Unsati__3F466844");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FeedBacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FeedBack__UserId__3D5E1FD2");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Product1).IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product__Categor__267ABA7A");
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.HasOne(d => d.CategoryPurchasedNavigation)
                    .WithMany(p => p.ProductInfos)
                    .HasForeignKey(d => d.CategoryPurchased)
                    .HasConstraintName("FK__Product_I__Categ__30F848ED");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInfos)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product_I__Produ__2F10007B");

                entity.HasOne(d => d.RatingNavigation)
                    .WithMany(p => p.ProductInfos)
                    .HasForeignKey(d => d.Rating)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Product_I__Ratin__300424B4");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.Rating1).IsUnicode(false);
            });

            modelBuilder.Entity<Unsatisfactory>(entity =>
            {
                entity.Property(e => e.FileUpload).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Unsatisfactories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Unsatisfa__UserI__35BCFE0A");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.AddressLine).IsUnicode(false);

                entity.Property(e => e.AddressLine2).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.First).IsUnicode(false);

                entity.Property(e => e.Initial).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
