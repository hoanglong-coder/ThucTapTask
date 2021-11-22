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
    public class TaskDbContext:DbContext
    {

        private const string connectionString = @"
                Data Source=DB_Name;
                Initial Catalog=mydata;
                User ID=sa;Password=sa2019";

        public DbSet<ChiTietDuAn> chiTietDuAns { set; get; }
        public DbSet<ChiTietTuan> chiTietTuans { set; get; }
        public DbSet<CongViec> congViecs { set; get; }
        public DbSet<DuAn> duAns { set; get; }
        public DbSet<Module> modules { set; get; }
        public DbSet<Quyen> quyens { set; get; }
        public DbSet<ToDo> toDos { set; get; }
        public DbSet<TuanLamViec> tuanLamViecs { set; get; }
        public DbSet<User> users { set; get; }
    }
}
