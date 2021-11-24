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
    public class DanhGiaThangConfiguration:IEntityTypeConfiguration<DanhGiaThang>
    {
        public void Configure(EntityTypeBuilder<DanhGiaThang> builder)
        {
            
        }
    }
}
