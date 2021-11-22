using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [StringLength(50)]
        public string MaUser { get; set; }

        [Required]
        [StringLength(250)]
        [Column(TypeName = "Nvarchar")]
        public string TenUser { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int TrangThai { get; set; }
    }
}
