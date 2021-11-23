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
    public class QuyenConfiguration : IEntityTypeConfiguration<Quyen>
    {
        public void Configure(EntityTypeBuilder<Quyen> builder)
        {
            builder.ToTable("Quyens");

            builder.HasKey(x => x.MaQuyen);

            builder.Property(x => x.MaQuyen).UseIdentityColumn(1, 1);

            builder.Property(x => x.TenQuyen).IsRequired(true);
        }
    }
}
