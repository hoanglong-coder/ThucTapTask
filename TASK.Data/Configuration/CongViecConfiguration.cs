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
    public class CongViecConfiguration : IEntityTypeConfiguration<CongViec>
    {
        public void Configure(EntityTypeBuilder<CongViec> builder)
        {
            builder.ToTable("CongViecs");

            builder.HasKey(x => x.MaCongViec);

            builder.HasOne(t => t.Module).WithMany(pc => pc.CongViecs)
                .HasForeignKey(pc => pc.MaModule);

            builder.Property(x => x.IssueURL).IsRequired().HasMaxLength(500);

            builder.Property(x => x.TenIssue).IsRequired().HasMaxLength(50);

            builder.Property(x => x.TenCongViec).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(x => x.Nguon).IsRequired();

            builder.Property(x => x.ThoiGianLam).IsRequired();

            builder.Property(x => x.TuNgay).IsRequired();

            builder.Property(x => x.DenNgay).IsRequired();

            builder.HasOne(t => t.TuanLamViec).WithMany(pc => pc.CongViecs)
                .HasForeignKey(pc => pc.MaThangLamViec);

            builder.HasOne(t => t.ChiTietTuan).WithMany(pc => pc.CongViecs)
                .HasForeignKey(pc => pc.MaTuanChiTiet);

            builder.HasOne(t => t.User).WithMany(pc => pc.CongViecs)
                .HasForeignKey(pc => pc.MaUser);

            builder.Property(x => x.GhiChu).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(x => x.TrangThai).IsRequired();
        }
    }
}
