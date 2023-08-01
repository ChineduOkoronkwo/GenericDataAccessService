using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericDataAccessService.Interfaces
{
    public interface IQueryExecutionService<U>
    {
        Task<int> ExecuteQuery(string connectionString, string sqlQuery, U? queryParams);
    }
}