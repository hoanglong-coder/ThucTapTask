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
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder.ToTable("ToDos");

            builder.HasKey(x => x.MaTodo);

            builder.Property(x => x.MaTodo).UseIdentityColumn(1, 1);

            builder.HasOne(t => t.User).WithMany(pc => pc.ToDos)
                .HasForeignKey(pc => pc.MaUser);

            builder.Property(x => x.NgayGiao);

            builder.Property(x => x.NgayDenHang);

            builder.Property(x => x.NoiDung).HasColumnType("nvarchar(max)");

            builder.Property(x => x.GhiChu).HasColumnType("nvarchar(max)");

            builder.Property(x => x.TrangThai).IsRequired();

            builder.HasOne(t => t.DuAn).WithMany(pc => pc.ToDos)
                .HasForeignKey(pc => pc.MaDuAn);
        }
    }
}
