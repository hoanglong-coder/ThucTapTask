using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK.Data;

namespace TASK.Application.MQuyen
{
    public class QuyenService : IQuyenService
    {
        private readonly TaskDbContext _taskDbContext;


        public QuyenService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }


        public Task<IEnumerable<QuyenResponse>> GetAll()
        {
            // return await _taskDbContext.Quyen.Select(t=>t).ToListAsync();
            throw new NotImplementedException();
        }
    }
}
