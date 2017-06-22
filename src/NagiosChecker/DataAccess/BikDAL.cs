using Dapper;
using NagiosChecker.Infrastructure.Repositories;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace NagiosChecker.DataAccess
{
    public class BikDAL : BaseDAL, IBikRepository
    {
        public BikDAL(string cs) : base(cs)
        {
        }

        /// <summary>
        /// Returns request time statistics
        /// </summary>
        public Tuple<int, TimeSpan, TimeSpan> BikKiGetAvgAndMedianResponseTime()
        {
            Tuple<int, TimeSpan, TimeSpan> result = null;
            string query = "select 100, cast('00:00:15' as time), cast('00:00:07' as time)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                result =
                    conn.Query<int, TimeSpan, TimeSpan, Tuple<int, TimeSpan, TimeSpan>>
                    (query, Tuple.Create, splitOn: "*").FirstOrDefault();
            }

            return result;
        }

        /// <summary>
        /// Returns request time statistics
        /// </summary>
        public Tuple<int, TimeSpan, TimeSpan> BikPGetAvgAndMedianResponseTime()
        {
            Tuple<int, TimeSpan, TimeSpan> result = null;
            string query = "select 200, cast('00:0:10' as time), cast('00:00:05' as time)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                result = conn.Query<int, TimeSpan, TimeSpan, Tuple<int, TimeSpan, TimeSpan>>
                    (query, Tuple.Create, splitOn: "*").FirstOrDefault();
            }

            return result;
        }

        /// <summary>
        /// Returns request statistics
        /// </summary>
        /// <returns>all reports amount and received reports amount</returns>
        public Tuple<long, long> BikPGetRequestsCountStatistics()
        {
            Tuple<long, long> result = null;
            string query = "SELECT cast(92 as bigint) , cast(100 as bigint)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                result = conn.Query<long, long, Tuple<long, long>>
                    (query, Tuple.Create, splitOn: "*").FirstOrDefault();
            }

            return result;
        }
    }
}
