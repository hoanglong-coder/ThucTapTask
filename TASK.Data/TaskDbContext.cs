using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data.Entities;

namespace TASK.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {

        }

        public DbSet<Quyen> Quyens { set; get; }
        //public DbSet<ChiTietDuAn> ChiTietDuAns { set; get; }
        //public DbSet<ChiTietTuan> ChiTietTuans { set; get; }
        //public DbSet<CongViec> CongViecs { set; get; }
        //public DbSet<DuAn> DuAns { set; get; }
        //public DbSet<Module> Modules { set; get; }
        //public DbSet<Quyen> Quyens { set; get; }
        //public DbSet<ToDo> ToDos { set; get; }
        //public DbSet<TuanLamViec> TuanLamViecs { set; get; }
        //public DbSet<User> Users { set; get; }
    }
}
