using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.API.Queries
{
    public interface IBaseCRUD<T,X,Z>
    {
        public Task<List<T>> GetAsync();
        public Task<T> GetIdAsync(Z id);
        public Task<T> AddAsync(X model);
        public Task UpdateAsync(Z id, X updateModel);
        public Task DeleteAsync(Z id);
    }
}
