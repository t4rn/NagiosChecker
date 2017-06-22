using Dapper;
using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NagiosChecker.DataAccess
{
    public class RexsDAL : BaseDAL, IRexsRepository
    {
        public RexsDAL(string cs) : base(cs)
        {
        }

        /// <summary>
        /// Returns a list of credit aaplications waiting for processing
        /// </summary>
        public List<TypeCount> CountApplicationsOnStatus()
        {
            List<TypeCount> list = new List<TypeCount>();

            string query = @"SELECT 10 as count, 'register' as type
                        UNION 
                        SELECT 5 as count, 'agreement' as type
                        UNION
                        SELECT 2 as count, 'docsub' as type";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                list = conn.Query<TypeCount>(query).AsList();
            }

            return list;
        }

        /// <summary>
        /// Returns the amount of pending conditions
        /// </summary>
        public int CountPendingConditions()
        {
            int count = -1;

            string query = "SELECT 125";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                count = conn.ExecuteScalar<int>(query);
            }

            return count;
        }

        /// <summary>
        /// Returns the amount of pending annexes
        /// </summary>
        public int CountPendingAnnexes()
        {
            int count = -1;

            string query = "SELECT 4";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                count = conn.ExecuteScalar<int>(query);
            }

            return count;
        }
    }
}
