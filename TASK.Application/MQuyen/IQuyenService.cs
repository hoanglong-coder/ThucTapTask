using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Application.MQuyen
{
    public interface IQuyenService
    {
        Task<IEnumerable<QuyenResponse>> GetAll();
    }
}
