using Dapper;
using NagiosChecker.Infrastructure.Repositories;
using System.Data.SqlClient;

namespace NagiosChecker.DataAccess
{
    public class KntDAL : BaseDAL, IKntRepository
    {
        public KntDAL(string cs) : base(cs)
        {
        }

        /// <summary>
        /// Returns pdf queue depth
        /// </summary>
        public int GetPdfQueueDepth()
        {
            int depth = -1;
            string query = "SELECT 11";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                depth = conn.ExecuteScalar<int>(query);
            }

            return depth;
        }
    }
}
