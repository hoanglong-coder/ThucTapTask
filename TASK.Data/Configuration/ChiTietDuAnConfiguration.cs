using TASK.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Configuration
{
    public class ChiTietDuAnConfiguration : IEntityTypeConfiguration<ChiTietDuAn>
    {
        public void Configure(EntityTypeBuilder<ChiTietDuAn> builder)
        {
            builder.HasKey(t => new { t.MaDuAn, t.MaUser });

            builder.ToTable("ChiTietDuAns");

            builder.HasOne(t => t.User).WithMany(pc => pc.ChiTietDuAns)
                .HasForeignKey(pc => pc.MaUser);

            builder.HasOne(t => t.DuAn).WithMany(pc => pc.ChiTietDuAns)
              .HasForeignKey(pc => pc.MaDuAn);

            builder.HasOne(t => t.Quyen).WithMany(pc => pc.ChiTietDuAns)
              .HasForeignKey(pc => pc.MaQuyen);
        }
    }
}
