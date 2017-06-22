using Dapper;
using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NagiosChecker.DataAccess
{
    public class SlDAL : BaseDAL, ISlRepository
    {
        public SlDAL(string cs) : base(cs)
        {
        }

        public List<TypeCount> CountLongProcessingReqeuests(DateTime sinceDate)
        {
            List<TypeCount> list = new List<TypeCount>();

            string query = @"SELECT 'PHASE1' as type, 0 as count
                            UNION
                                SELECT 'PHASE2' as type, 1 as count";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                list = conn.Query<TypeCount>(query, new { sinceDate = sinceDate }).AsList();
            }

            return list;
        }

        public List<TypeCount> CountPendingRequests()
        {
            List<TypeCount> list = new List<TypeCount>();

            string query = @"SELECT 'WAIT' as type, 1 as count
                            UNION
                            SELECT 'PHASE1' as type, 2 as count
                            UNION 
                            SELECT 'PHASE2' as type, 3 as count";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                list = conn.Query<TypeCount>(query).AsList();
            }

            return list;
        }

        public List<DateTime> GetErrors(DateTime sinceDate)
        {
            List<DateTime> errorDateList = new List<DateTime>();

            string query = @"SELECT cast('2017-05-01' as date)
                                UNION SELECT cast('2017-05-04' as date)
                                UNION SELECT cast('2017-05-07' as date);";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                errorDateList = conn.Query<DateTime>(query, new { sinceDate = sinceDate }).AsList();
            }

            return errorDateList;
        }
    }
}
