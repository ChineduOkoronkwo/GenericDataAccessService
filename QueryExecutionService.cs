
using GenericDataAccessService.Interfaces;
using Dapper;
using Npgsql;

namespace GenericDataAccessService
{
    public class QueryExecutionService<U> : IQueryExecutionService<U>
    {
        public async Task<int> ExecuteQuery(string connectionString, string sqlQuery, U? queryParams)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                if (queryParams == null)
                {
                    return await connection.ExecuteAsync(sqlQuery);
                }
                object[] parameters = {queryParams!};
                return await connection.ExecuteAsync(sqlQuery, parameters);
            }
        }
    }
}