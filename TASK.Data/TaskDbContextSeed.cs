using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data.Entities;

namespace TASK.Data
{
    public class TaskDbContextSeed
    {
        public async Task SeedAsync(TaskDbContext context, ILogger<TaskDbContext> logger)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new Entities.User()
                {
                    MaUser = Guid.Parse("70ca845c-1621-4469-a746-2fab0e9b4f9d"),
                    TenUser = "Nguyen Van A",
                    UserName = "nguyenvana",
                    Password = "25f9e794323b453885f5181f1b624d0b",
                    TrangThai = true
                });
            }
            if (!context.DuAns.Any())
            {
                context.DuAns.Add(new Entities.DuAn()
                {
                    TenDuAn = "Dự án 1",
                    TrangThai = 1
                });
                context.DuAns.Add(new Entities.DuAn()
                {
                    TenDuAn = "Dự án 2",
                    TrangThai = 1
                });
                context.DuAns.Add(new Entities.DuAn()
                {
                    TenDuAn = "Dự án 3",
                    TrangThai = 1
                });
                context.DuAns.Add(new Entities.DuAn()
                {
                    TenDuAn = "Dự án 4",
                    TrangThai = 1
                });
            }
            if (!context.Quyens.Any())
            {
                context.Quyens.Add(new Entities.Quyen()
                {
                    TenQuyen = "Admin"
                });
                context.Quyens.Add(new Entities.Quyen()
                {
                    TenQuyen = "Leader"
                });
                context.Quyens.Add(new Entities.Quyen()
                {
                    TenQuyen = "Member"
                });
            }
            if (!context.ChiTietDuAns.Any())
            {
                context.ChiTietDuAns.Add(new Entities.ChiTietDuAn()
                {
                    MaDuAn = 1,
                    MaUser = Guid.Parse("70ca845c-1621-4469-a746-2fab0e9b4f9d"),
                    MaQuyen = 1
                });
                context.ChiTietDuAns.Add(new Entities.ChiTietDuAn()
                {
                    MaDuAn = 2,
                    MaUser = Guid.Parse("70ca845c-1621-4469-a746-2fab0e9b4f9d"),
                    MaQuyen = 2
                });
                context.ChiTietDuAns.Add(new Entities.ChiTietDuAn()
                {
                    MaDuAn = 3,
                    MaUser = Guid.Parse("70ca845c-1621-4469-a746-2fab0e9b4f9d"),
                    MaQuyen = 3
                });
            }

            await context.SaveChangesAsync();
        }
    }
}
