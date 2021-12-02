﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TASK.Data;

namespace TASK.Data.Migrations
{
    [DbContext(typeof(TaskDbContext))]
    partial class TaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TASK.Data.Entities.ChiTietDuAn", b =>
                {
                    b.Property<int?>("MaDuAn")
                        .HasColumnType("int");

                    b.Property<Guid?>("MaUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("MaQuyen")
                        .HasColumnType("int");

                    b.HasKey("MaDuAn", "MaUser");

                    b.HasIndex("MaQuyen");

                    b.HasIndex("MaUser");

                    b.ToTable("ChiTietDuAns");
                });

            modelBuilder.Entity("TASK.Data.Entities.ChiTietTuan", b =>
                {
                    b.Property<int>("MaTuanChiTiet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DenNgay")
                        .HasColumnType("datetime2");

                    b.Property<int>("GiaTri")
                        .HasColumnType("int");

                    b.Property<int?>("MaThangLamViec")
                        .HasColumnType("int");

                    b.Property<int>("SoGioLam")
                        .HasColumnType("int");

                    b.Property<string>("TenTuan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TuNgay")
                        .HasColumnType("datetime2");

                    b.HasKey("MaTuanChiTiet");

                    b.HasIndex("MaThangLamViec");

                    b.ToTable("ChiTietTuans");
                });

            modelBuilder.Entity("TASK.Data.Entities.CongViec", b =>
                {
                    b.Property<int>("MaCongViec")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DaDuyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DenNgay")
                        .HasColumnType("datetime2");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueURL")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("MaModule")
                        .HasColumnType("int");

                    b.Property<int?>("MaThangLamViec")
                        .HasColumnType("int");

                    b.Property<int?>("MaTuanChiTiet")
                        .HasColumnType("int");

                    b.Property<Guid?>("MaUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Nguon")
                        .HasColumnType("int");

                    b.Property<string>("TenCongViec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenIssue")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ThoiGianLam")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<DateTime>("TuNgay")
                        .HasColumnType("datetime2");

                    b.HasKey("MaCongViec");

                    b.HasIndex("MaThangLamViec");

                    b.HasIndex("MaTuanChiTiet");

                    b.HasIndex("MaUser");

                    b.ToTable("CongViecs");
                });

            modelBuilder.Entity("TASK.Data.Entities.DanhGiaThang", b =>
                {
                    b.Property<int>("MaDanhGiaThang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChatLuong")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("KhoiLuong")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("MaTuanLamViec")
                        .HasColumnType("int");

                    b.Property<string>("NhanXet")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TienDo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("TrungBinhThang")
                        .HasColumnType("real");

                    b.Property<string>("XepLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("MaDanhGiaThang");

                    b.HasIndex("MaTuanLamViec");

                    b.ToTable("DanhGiaThangs");
                });

            modelBuilder.Entity("TASK.Data.Entities.DanhGiaTuan", b =>
                {
                    b.Property<int>("MaDanhGiaTuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChatLuong")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("HoanThanh")
                        .HasColumnType("real");

                    b.Property<string>("KhoiLuong")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LoiTrongTuan")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("MaChiTietTuan")
                        .HasColumnType("int");

                    b.Property<int?>("MaDanhGiaThang")
                        .HasColumnType("int");

                    b.Property<string>("NhanXetTuan")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TienDo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("MaDanhGiaTuan");

                    b.HasIndex("MaChiTietTuan");

                    b.HasIndex("MaDanhGiaThang");

                    b.ToTable("DanhGiaTuans");
                });

            modelBuilder.Entity("TASK.Data.Entities.DuAn", b =>
                {
                    b.Property<int>("MaDuAn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenDuAn")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaDuAn");

                    b.ToTable("DuAns");
                });

            modelBuilder.Entity("TASK.Data.Entities.Module", b =>
                {
                    b.Property<int>("MaModule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenModule")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaModule");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("TASK.Data.Entities.Quyen", b =>
                {
                    b.Property<int>("MaQuyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaQuyen");

                    b.ToTable("Quyens");
                });

            modelBuilder.Entity("TASK.Data.Entities.QuyenHeThong", b =>
                {
                    b.Property<int>("MaQuyenHeThong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaQuyenHeThong");

                    b.ToTable("QuyenHeThongs");
                });

            modelBuilder.Entity("TASK.Data.Entities.ToDo", b =>
                {
                    b.Property<int>("MaTodo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaDuAn")
                        .HasColumnType("int");

                    b.Property<Guid?>("MaUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDenHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaTodo");

                    b.HasIndex("MaDuAn");

                    b.HasIndex("MaUser");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("TASK.Data.Entities.TuanLamViec", b =>
                {
                    b.Property<int>("MaThangLamViec")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiaTri")
                        .HasColumnType("int");

                    b.Property<int?>("MaDuAn")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenThang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaThangLamViec");

                    b.HasIndex("MaDuAn");

                    b.ToTable("TuanLamViecs");
                });

            modelBuilder.Entity("TASK.Data.Entities.User", b =>
                {
                    b.Property<Guid>("MaUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaQuyenHeThong")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenUser")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaUser");

                    b.HasIndex("MaQuyenHeThong");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TASK.Data.Entities.ChiTietDuAn", b =>
                {
                    b.HasOne("TASK.Data.Entities.DuAn", "DuAn")
                        .WithMany("ChiTietDuAns")
                        .HasForeignKey("MaDuAn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TASK.Data.Entities.Quyen", "Quyen")
                        .WithMany("ChiTietDuAns")
                        .HasForeignKey("MaQuyen");

                    b.HasOne("TASK.Data.Entities.User", "User")
                        .WithMany("ChiTietDuAns")
                        .HasForeignKey("MaUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DuAn");

                    b.Navigation("Quyen");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TASK.Data.Entities.ChiTietTuan", b =>
                {
                    b.HasOne("TASK.Data.Entities.TuanLamViec", "TuanLamViec")
                        .WithMany("ChiTietTuans")
                        .HasForeignKey("MaThangLamViec");

                    b.Navigation("TuanLamViec");
                });

            modelBuilder.Entity("TASK.Data.Entities.CongViec", b =>
                {
                    b.HasOne("TASK.Data.Entities.TuanLamViec", "TuanLamViec")
                        .WithMany("CongViecs")
                        .HasForeignKey("MaThangLamViec");

                    b.HasOne("TASK.Data.Entities.ChiTietTuan", "ChiTietTuan")
                        .WithMany("CongViecs")
                        .HasForeignKey("MaTuanChiTiet");

                    b.HasOne("TASK.Data.Entities.User", "User")
                        .WithMany("CongViecs")
                        .HasForeignKey("MaUser");

                    b.Navigation("ChiTietTuan");

                    b.Navigation("TuanLamViec");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TASK.Data.Entities.DanhGiaThang", b =>
                {
                    b.HasOne("TASK.Data.Entities.TuanLamViec", "TuanLamViec")
                        .WithMany("DanhGiaThangs")
                        .HasForeignKey("MaTuanLamViec");

                    b.Navigation("TuanLamViec");
                });

            modelBuilder.Entity("TASK.Data.Entities.DanhGiaTuan", b =>
                {
                    b.HasOne("TASK.Data.Entities.ChiTietTuan", "ChiTietTuan")
                        .WithMany("DanhGiaTuans")
                        .HasForeignKey("MaChiTietTuan");

                    b.HasOne("TASK.Data.Entities.DanhGiaThang", "DanhGiaThang")
                        .WithMany("DanhGiaTuans")
                        .HasForeignKey("MaDanhGiaThang");

                    b.Navigation("ChiTietTuan");

                    b.Navigation("DanhGiaThang");
                });

            modelBuilder.Entity("TASK.Data.Entities.ToDo", b =>
                {
                    b.HasOne("TASK.Data.Entities.DuAn", "DuAn")
                        .WithMany("ToDos")
                        .HasForeignKey("MaDuAn");

                    b.HasOne("TASK.Data.Entities.User", "User")
                        .WithMany("ToDos")
                        .HasForeignKey("MaUser");

                    b.Navigation("DuAn");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TASK.Data.Entities.TuanLamViec", b =>
                {
                    b.HasOne("TASK.Data.Entities.DuAn", "DuAn")
                        .WithMany("TuanLamViecs")
                        .HasForeignKey("MaDuAn");

                    b.Navigation("DuAn");
                });

            modelBuilder.Entity("TASK.Data.Entities.User", b =>
                {
                    b.HasOne("TASK.Data.Entities.QuyenHeThong", "QuyenHeThong")
                        .WithMany("Users")
                        .HasForeignKey("MaQuyenHeThong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuyenHeThong");
                });

            modelBuilder.Entity("TASK.Data.Entities.ChiTietTuan", b =>
                {
                    b.Navigation("CongViecs");

                    b.Navigation("DanhGiaTuans");
                });

            modelBuilder.Entity("TASK.Data.Entities.DanhGiaThang", b =>
                {
                    b.Navigation("DanhGiaTuans");
                });

            modelBuilder.Entity("TASK.Data.Entities.DuAn", b =>
                {
                    b.Navigation("ChiTietDuAns");

                    b.Navigation("ToDos");

                    b.Navigation("TuanLamViecs");
                });

            modelBuilder.Entity("TASK.Data.Entities.Quyen", b =>
                {
                    b.Navigation("ChiTietDuAns");
                });

            modelBuilder.Entity("TASK.Data.Entities.QuyenHeThong", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TASK.Data.Entities.TuanLamViec", b =>
                {
                    b.Navigation("ChiTietTuans");

                    b.Navigation("CongViecs");

                    b.Navigation("DanhGiaThangs");
                });

            modelBuilder.Entity("TASK.Data.Entities.User", b =>
                {
                    b.Navigation("ChiTietDuAns");

                    b.Navigation("CongViecs");

                    b.Navigation("ToDos");
                });
#pragma warning restore 612, 618
        }
    }
}
