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
    public class TuanLamViecConfiguration : IEntityTypeConfiguration<TuanLamViec>
    {
        public void Configure(EntityTypeBuilder<TuanLamViec> builder)
        {
            builder.ToTable("TuanLamViecs");

            builder.HasKey(x => x.MaThangLamViec);

            builder.Property(x => x.MaThangLamViec).UseIdentityColumn(1, 1);

            builder.Property(x => x.TenThang).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");

            builder.Property(x => x.GiaTri).IsRequired();

            builder.Property(x => x.NgayBatDau).IsRequired();

            builder.Property(x => x.NgayKetThuc).IsRequired();

            builder.HasOne(t => t.DuAn).WithMany(pc => pc.TuanLamViecs)
                .HasForeignKey(pc => pc.MaDuAn);
        }
    }
}
