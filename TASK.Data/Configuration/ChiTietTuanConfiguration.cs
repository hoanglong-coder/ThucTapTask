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
    public class ChiTietTuanConfiguration : IEntityTypeConfiguration<ChiTietTuan>
    {
        public void Configure(EntityTypeBuilder<ChiTietTuan> builder)
        {
            builder.ToTable("ChiTietTuans");

            builder.HasKey(x => x.MaTuanChiTiet);

            builder.Property(x => x.MaTuanChiTiet).UseIdentityColumn(1, 1);

            builder.Property(x => x.TenTuan).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");

            builder.Property(x => x.TuNgay).IsRequired();

            builder.Property(x => x.DenNgay).IsRequired();

            builder.Property(x => x.GiaTri).IsRequired();

            builder.Property(x => x.SoGioLam).IsRequired();

            builder.Property(x => x.TrangThai).IsRequired();

            builder.HasOne(t => t.TuanLamViec).WithMany(pc => pc.ChiTietTuans)
                .HasForeignKey(pc => pc.MaThangLamViec);
        }
    }
}
