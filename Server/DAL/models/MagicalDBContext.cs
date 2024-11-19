using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.models
{
    public partial class MagicalDBContext : DbContext
    {
        public MagicalDBContext()
        {
        }

        public MagicalDBContext(DbContextOptions<MagicalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryProductTbl> CategoryProductTbls { get; set; } = null!;
        public virtual DbSet<CategoryTbl> CategoryTbls { get; set; } = null!;
        public virtual DbSet<CityTbl> CityTbls { get; set; } = null!;
        public virtual DbSet<ColorTbl> ColorTbls { get; set; } = null!;
        public virtual DbSet<GeneralProductTbl> GeneralProductTbls { get; set; } = null!;
        public virtual DbSet<OrdersTbl> OrdersTbls { get; set; } = null!;
        public virtual DbSet<PictureTbl> PictureTbls { get; set; } = null!;
        public virtual DbSet<ProductOrderTbl> ProductOrderTbls { get; set; } = null!;
        public virtual DbSet<ProductTbl> ProductTbls { get; set; } = null!;
        public virtual DbSet<UserTbl> UserTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-783IDMP\\SQLEXPRESS;Database=MagicalDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryProductTbl>(entity =>
            {
                entity.HasKey(e => e.CpId);

                entity.ToTable("CategoryProductTbl");

                entity.Property(e => e.CpId).HasColumnName("cpId");

                entity.Property(e => e.CpCatId).HasColumnName("cpCatId");

                entity.Property(e => e.CpGenProdId).HasColumnName("cpGenProdId");

                entity.HasOne(d => d.CpCat)
                    .WithMany(p => p.CategoryProductTbls)
                    .HasForeignKey(d => d.CpCatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryProductTbl_CategoryTbl");

                entity.HasOne(d => d.CpGenProd)
                    .WithMany(p => p.CategoryProductTbls)
                    .HasForeignKey(d => d.CpGenProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryProductTbl_GeneralProductTbl");
            });

            modelBuilder.Entity<CategoryTbl>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("CategoryTbl");

                entity.Property(e => e.CatId).HasColumnName("catId");

                entity.Property(e => e.CatName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("catName");
            });

            modelBuilder.Entity<CityTbl>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_CityTvl");

                entity.ToTable("CityTbl");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CityName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cityName");

                entity.Property(e => e.CityShippPrice).HasColumnName("cityShippPrice");
            });

            modelBuilder.Entity<ColorTbl>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.ToTable("ColorTbl");

                entity.Property(e => e.ColorId).HasColumnName("colorId");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(50)
                    .HasColumnName("colorName");
            });

            modelBuilder.Entity<GeneralProductTbl>(entity =>
            {
                entity.HasKey(e => e.GenProdId);

                entity.ToTable("GeneralProductTbl");

                entity.Property(e => e.GenProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("genProdId");

                entity.Property(e => e.GenProdName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genProdName");
            });

            modelBuilder.Entity<OrdersTbl>(entity =>
            {
                entity.HasKey(e => e.OrdId);

                entity.ToTable("OrdersTbl");

                entity.Property(e => e.OrdId).HasColumnName("ordId");

                entity.Property(e => e.OrdDate)
                    .HasColumnType("date")
                    .HasColumnName("ordDate");

                entity.Property(e => e.OrdDateSend)
                    .HasColumnType("date")
                    .HasColumnName("ordDateSend");

                entity.Property(e => e.OrdStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ordStatus");

                entity.Property(e => e.OrdTotalPayment).HasColumnName("ordTotalPayment");

                entity.Property(e => e.OrdUserId).HasColumnName("ordUserId");

                entity.HasOne(d => d.OrdUser)
                    .WithMany(p => p.OrdersTbls)
                    .HasForeignKey(d => d.OrdUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersTbl_UserTbl");
            });

            modelBuilder.Entity<PictureTbl>(entity =>
            {
                entity.HasKey(e => e.PicId)
                    .HasName("PK_PictureTbl_1");

                entity.ToTable("PictureTbl");

                entity.Property(e => e.PicId).HasColumnName("picId");

                entity.Property(e => e.PicName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("picName");

                entity.Property(e => e.PicProdId).HasColumnName("picProdId");

                entity.HasOne(d => d.PicProd)
                    .WithMany(p => p.PictureTbls)
                    .HasForeignKey(d => d.PicProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PictureTbl_ProductTbl");
            });

            modelBuilder.Entity<ProductOrderTbl>(entity =>
            {
                entity.HasKey(e => e.PoId);

                entity.ToTable("ProductOrderTbl");

                entity.Property(e => e.PoId)
                    .ValueGeneratedNever()
                    .HasColumnName("poId");

                entity.Property(e => e.PoAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("poAddress");

                entity.Property(e => e.PoCityId).HasColumnName("poCityId");

                entity.Property(e => e.PoNameGet)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("poNameGet");

                entity.Property(e => e.PoNote)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("poNote");

                entity.Property(e => e.PoOrdId).HasColumnName("poOrdId");

                entity.Property(e => e.PoProdId).HasColumnName("poProdId");

                entity.Property(e => e.PoUserId).HasColumnName("poUserId");

                entity.HasOne(d => d.PoCity)
                    .WithMany(p => p.ProductOrderTbls)
                    .HasForeignKey(d => d.PoCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOrderTbl_CityTbl");

                entity.HasOne(d => d.PoOrd)
                    .WithMany(p => p.ProductOrderTbls)
                    .HasForeignKey(d => d.PoOrdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOrderTbl_OrdersTbl");

                entity.HasOne(d => d.PoProd)
                    .WithMany(p => p.ProductOrderTbls)
                    .HasForeignKey(d => d.PoProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOrderTbl_ProductTbl");

                entity.HasOne(d => d.PoUser)
                    .WithMany(p => p.ProductOrderTbls)
                    .HasForeignKey(d => d.PoUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOrderTbl_UserTbl");
            });

            modelBuilder.Entity<ProductTbl>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("ProductTbl");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("prodId");

                entity.Property(e => e.ProdColorId).HasColumnName("prodColorId");

                entity.Property(e => e.ProdDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prodDesc");

                entity.Property(e => e.ProdGeneralId).HasColumnName("prodGeneralId");

                entity.Property(e => e.ProdInSale).HasColumnName("prodInSale");

                entity.Property(e => e.ProdInStack).HasColumnName("prodInStack");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("prodName");

                entity.Property(e => e.ProdPic)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("prodPic");

                entity.Property(e => e.ProdPrice).HasColumnName("prodPrice");

                entity.Property(e => e.ProdQty).HasColumnName("prodQty");

                entity.Property(e => e.ProdSalePrice).HasColumnName("prodSalePrice");

                entity.Property(e => e.ProdStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("prodStatus");

                entity.HasOne(d => d.ProdColor)
                    .WithMany(p => p.ProductTbls)
                    .HasForeignKey(d => d.ProdColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTbl_ColorTbl");

                entity.HasOne(d => d.ProdGeneral)
                    .WithMany(p => p.ProductTbls)
                    .HasForeignKey(d => d.ProdGeneralId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTbl_GeneralProductTbl");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserTbl");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("userAddress");

                entity.Property(e => e.UserCityId).HasColumnName("userCityId");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userPass");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userPhone");

                entity.HasOne(d => d.UserCity)
                    .WithMany(p => p.UserTbls)
                    .HasForeignKey(d => d.UserCityId)
                    .HasConstraintName("FK_UserTbl_CityTbl");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
