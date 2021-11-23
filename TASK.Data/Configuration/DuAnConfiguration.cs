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
    public class DuAnConfiguration : IEntityTypeConfiguration<DuAn>
    {
        public void Configure(EntityTypeBuilder<DuAn> builder)
        {
            builder.ToTable("DuAns");

            builder.HasKey(x => x.MaDuAn);

            builder.Property(x => x.TenDuAn).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");

            builder.Property(x => x.TrangThai).IsRequired();
        }
    }
}
