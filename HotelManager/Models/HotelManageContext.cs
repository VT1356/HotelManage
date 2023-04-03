using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HotelManager.Models;

public partial class HotelManageContext : DbContext
{
    public HotelManageContext()
    {
    }

    public HotelManageContext(DbContextOptions<HotelManageContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbCongTy> TbCongTies { get; set; }

    public virtual DbSet<TbDatPhong> TbDatPhongs { get; set; }

    public virtual DbSet<TbDonVi> TbDonVis { get; set; }

    public virtual DbSet<TbKhachHang> TbKhachHangs { get; set; }

    public virtual DbSet<TbLoaiPhong> TbLoaiPhongs { get; set; }

    public virtual DbSet<TbPhong> TbPhongs { get; set; }

    public virtual DbSet<TbPhongThietBi> TbPhongThietBis { get; set; }

    public virtual DbSet<TbSanPham> TbSanPhams { get; set; }

    public virtual DbSet<TbSysUser> TbSysUsers { get; set; }

    public virtual DbSet<TbTang> TbTangs { get; set; }

    public virtual DbSet<TbThietBi> TbThietBis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DatabasePath"));
        };
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbCongTy>(entity =>
        {
            entity.HasKey(e => e.Macty);

            entity.ToTable("tb_CongTy");

            entity.Property(e => e.Macty)
                .HasMaxLength(10)
                .HasColumnName("MACTY");
            entity.Property(e => e.Diachi).HasColumnName("DIACHI");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(10)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("EMAIL");
            
            entity.Property(e => e.Tencty).HasColumnName("TENCTY");
        });

        modelBuilder.Entity<TbDatPhong>(entity =>
        {
            entity.ToTable("tb_DatPhong");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idkh).HasColumnName("IDKH");
            entity.Property(e => e.Idphong).HasColumnName("IDPHONG");
            entity.Property(e => e.Idsp).HasColumnName("IDSP");
            entity.Property(e => e.Macty)
                .HasMaxLength(10)
                .HasColumnName("MACTY");
            entity.Property(e => e.Madvi)
                .HasMaxLength(10)
                .HasColumnName("MADVI");
            entity.Property(e => e.Ngaydat)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDAT");
            entity.Property(e => e.Ngaytra)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTRA");
            entity.Property(e => e.Songayo).HasColumnName("SONGAYO");
            entity.Property(e => e.Uid).HasColumnName("UID");

            entity.HasOne(d => d.TbKhachHang).WithMany(p => p.TbDatPhongs)
                .HasForeignKey(d => d.Idkh)
                .HasConstraintName("FK_tb_DatPhong_tb_KhachHang");

            entity.HasOne(d => d.TbPhong).WithMany(p => p.TbDatPhongs)
                .HasForeignKey(d => d.Idphong)
                .HasConstraintName("FK_tb_DatPhong_tb_Phong");

            entity.HasOne(d => d.TbSanPham).WithMany(p => p.TbDatPhongs)
                .HasForeignKey(d => d.Idsp)
                .HasConstraintName("FK_tb_DatPhong_tb_SanPham");

            entity.HasOne(d => d.TbCongTy).WithMany(p => p.TbDatPhongs)
                .HasForeignKey(d => d.Macty)
                .HasConstraintName("FK_tb_DatPhong_tb_CongTy");

            entity.HasOne(d => d.TbDonVi).WithMany(p => p.TbDatPhongs)
                .HasForeignKey(d => d.Madvi)
                .HasConstraintName("FK_tb_DatPhong_tb_DonVi");

            entity.HasOne(d => d.TbSysUser).WithMany(p => p.TbDatPhongs)
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("FK_tb_DatPhong_tb_Sys_User");
        });

        modelBuilder.Entity<TbDonVi>(entity =>
        {
            entity.HasKey(e => e.Madvi);

            entity.ToTable("tb_DonVi");

            entity.Property(e => e.Madvi)
                .HasMaxLength(10)
                .HasColumnName("MADVI");
            entity.Property(e => e.Diachi).HasColumnName("DIACHI");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(10)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
           
            entity.Property(e => e.Macty)
                .HasMaxLength(10)
                .HasColumnName("MACTY");
            entity.Property(e => e.Tendvi).HasColumnName("TENDVI");

            entity.HasOne(d => d.TbCongTy).WithMany(p => p.TbDonVis)
                .HasForeignKey(d => d.Macty)
                .HasConstraintName("FK_tb_DonVi_tb_CongTy");
        });

        modelBuilder.Entity<TbKhachHang>(entity =>
        {
            entity.HasKey(e => e.Idkh);

            entity.ToTable("tb_KhachHang");

            entity.Property(e => e.Idkh).HasColumnName("IDKH");
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .HasColumnName("CCCD");
            entity.Property(e => e.Diachi).HasColumnName("DIACHI");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(10)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
        });

        modelBuilder.Entity<TbLoaiPhong>(entity =>
        {
            entity.HasKey(e => e.Idloaiphong);

            entity.ToTable("tb_LoaiPhong");

            entity.Property(e => e.Idloaiphong).HasColumnName("IDLOAIPHONG");
            entity.Property(e => e.Dongia).HasColumnName("DONGIA");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Songuoi).HasColumnName("SONGUOI");
            entity.Property(e => e.Tenloaiphong)
                .HasMaxLength(50)
                .HasColumnName("TENLOAIPHONG");
        });

        modelBuilder.Entity<TbPhong>(entity =>
        {
            entity.HasKey(e => e.Idphong);

            entity.ToTable("tb_Phong");

            entity.Property(e => e.Idphong).HasColumnName("IDPHONG");
            entity.Property(e => e.Idloaiphong).HasColumnName("IDLOAIPHONG");
            entity.Property(e => e.Idtang).HasColumnName("IDTANG");
            entity.Property(e => e.Tenphong)
                .HasMaxLength(50)
                .HasColumnName("TENPHONG");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.TbLoaiPhong).WithMany(p => p.TbPhongs)
                .HasForeignKey(d => d.Idloaiphong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Phong_tb_LoaiPhong");

            entity.HasOne(d => d.TbTang).WithMany(p => p.TbPhongs)
                .HasForeignKey(d => d.Idtang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Phong_tb_Tang");
        });

        modelBuilder.Entity<TbPhongThietBi>(entity =>
        {
            entity.HasKey(e => e.Idphong);

            entity.ToTable("tb_Phong_ThietBi");

            entity.Property(e => e.Idphong)
                .ValueGeneratedNever()
                .HasColumnName("IDPHONG");
            entity.Property(e => e.Idtb).HasColumnName("IDTB");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

            entity.HasOne(d => d.IdtbNavigation).WithMany(p => p.TbPhongThietBis)
                .HasForeignKey(d => d.Idtb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_Phong_ThietBi_tb_ThietBi");
        });

        modelBuilder.Entity<TbSanPham>(entity =>
        {
            entity.HasKey(e => e.Idsp);

            entity.ToTable("tb_SanPham");

            entity.Property(e => e.Idsp).HasColumnName("IDSP");
            entity.Property(e => e.Dongia).HasColumnName("DONGIA");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("TENSP");
        });

        modelBuilder.Entity<TbSysUser>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("tb_Sys_User");

            entity.Property(e => e.Uid).HasColumnName("UID");
            entity.Property(e => e.Disabled).HasColumnName("DISABLED");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Isgroup).HasColumnName("ISGROUP");
            entity.Property(e => e.Macty)
                .HasMaxLength(10)
                .HasColumnName("MACTY");
            entity.Property(e => e.Madvi)
                .HasMaxLength(10)
                .HasColumnName("MADVI");
            entity.Property(e => e.Passwd)
                .HasMaxLength(50)
                .HasColumnName("PASSWD");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<TbTang>(entity =>
        {
            entity.HasKey(e => e.Idtang);

            entity.ToTable("tb_Tang");

            entity.Property(e => e.Idtang).HasColumnName("IDTANG");
            entity.Property(e => e.Tentang)
                .HasMaxLength(50)
                .HasColumnName("TENTANG");
        });

        modelBuilder.Entity<TbThietBi>(entity =>
        {
            entity.HasKey(e => e.Idtb);

            entity.ToTable("tb_ThietBi");

            entity.Property(e => e.Idtb).HasColumnName("IDTB");
            entity.Property(e => e.Dongia).HasColumnName("DONGIA");
            entity.Property(e => e.Tentb)
                .HasMaxLength(50)
                .HasColumnName("TENTB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
