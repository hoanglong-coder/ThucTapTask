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
    public class QuyenHeThongConfiguration : IEntityTypeConfiguration<QuyenHeThong>
    {
        public void Configure(EntityTypeBuilder<QuyenHeThong> builder)
        {
            builder.ToTable("QuyenHeThongs");

            builder.HasKey(x => x.MaQuyenHeThong);

            builder.Property(x => x.MaQuyenHeThong).UseIdentityColumn(1, 1);

            builder.Property(x => x.TenQuyen).IsRequired(true);
        }
    }
}
