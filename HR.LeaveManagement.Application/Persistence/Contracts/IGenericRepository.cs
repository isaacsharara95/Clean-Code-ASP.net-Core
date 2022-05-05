using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
   public interface IGenericRepository<Z> where Z:class
    {
        Task<Z> Get(int Id);
        Task<IReadOnlyList<Z>> GetAll();
        Task<Z> Add(Z entity);
        Task<Z> Delete(Z entity);
        Task<Z> Update(Z entity);
    }
}
