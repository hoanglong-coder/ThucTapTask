using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data.Configuration;
using TASK.Data.Entities;

namespace TASK.Data
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChiTietDuAnConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietTuanConfiguration());
            modelBuilder.ApplyConfiguration(new CongViecConfiguration());
            modelBuilder.ApplyConfiguration(new DuAnConfiguration());
            modelBuilder.ApplyConfiguration(new ModuleConfiguration());
            modelBuilder.ApplyConfiguration(new QuyenConfiguration());
            modelBuilder.ApplyConfiguration(new ToDoConfiguration());
            modelBuilder.ApplyConfiguration(new TuanLamViecConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DanhGiaThangConfiguration());
            modelBuilder.ApplyConfiguration(new DanhGiaTuanConfiguration());
            modelBuilder.ApplyConfiguration(new QuyenHeThongConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<QuyenHeThong> QuyenHeThongs { set; get; }
        public DbSet<Quyen> Quyens { set; get; }
        public DbSet<ChiTietDuAn> ChiTietDuAns { set; get; }
        public DbSet<ChiTietTuan> ChiTietTuans { set; get; }
        public DbSet<CongViec> CongViecs { set; get; }
        public DbSet<DuAn> DuAns { set; get; }
        public DbSet<Module> Modules { set; get; }
        public DbSet<ToDo> ToDos { set; get; }
        public DbSet<TuanLamViec> TuanLamViecs { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<DanhGiaThang> DanhGiaThangs { set; get; }
        public DbSet<DanhGiaTuan> DanhGiaTuans { set; get; }
    }
}
