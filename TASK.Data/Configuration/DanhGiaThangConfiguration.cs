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
    public class DanhGiaThangConfiguration : IEntityTypeConfiguration<DanhGiaThang>
    {
        public void Configure(EntityTypeBuilder<DanhGiaThang> builder)
        {
            builder.ToTable("DanhGiaThangs");

            builder.HasKey(x => x.MaDanhGiaThang);

            builder.Property(x => x.MaDanhGiaThang).UseIdentityColumn(1, 1);

            builder.Property(x => x.KhoiLuong).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.TienDo).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.ChatLuong).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");
            
            builder.Property(x => x.TrungBinhThang);

            builder.Property(x => x.XepLoai).IsRequired();

            builder.Property(x => x.NhanXet).HasMaxLength(250).HasColumnType("nvarchar");

            builder.HasOne(t => t.TuanLamViec).WithMany(pc => pc.DanhGiaThangs)
                .HasForeignKey(pc => pc.MaTuanLamViec);
        }
    }
}
