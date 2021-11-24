using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data.Entities;

namespace TASK.Data.Configuration
{
    public class DanhGiaTuanConfiguration : IEntityTypeConfiguration<DanhGiaTuan>
    {
        public void Configure(EntityTypeBuilder<DanhGiaTuan> builder)
        {
            builder.ToTable("DanhGiaTuans");

            builder.HasKey(x => x.MaDanhGiaTuan);

            builder.Property(x => x.MaDanhGiaTuan).UseIdentityColumn(1, 1);

            builder.Property(x => x.KhoiLuong).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.TienDo).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.ChatLuong).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.LoiTrongTuan).HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.NhanXetTuan).HasMaxLength(250).HasColumnType("nvarchar");

            builder.HasOne(t => t.DanhGiaThang).WithMany(pc => pc.DanhGiaTuans)
                .HasForeignKey(pc => pc.MaDanhGiaThang);

            builder.HasOne(t => t.ChiTietTuan).WithMany(pc => pc.DanhGiaTuans)
                .HasForeignKey(pc => pc.MaChiTietTuan);
        }
    }
}
