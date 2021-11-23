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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.MaUser);

            builder.Property(x => x.TenUser).IsRequired().HasMaxLength(250).HasColumnType("nvarchar");
            
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            
            builder.Property(x => x.TrangThai).IsRequired();
        }
    }
}
