using Dapper;
using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NagiosChecker.DataAccess
{
    public class MsSqlDAL : BaseDAL, IMsSqlRepository
    {
        public MsSqlDAL(string cs) : base(cs)
        {
        }

        public IEnumerable<SpWho2Session> GetSessions()
        {
            string query = "sp_who2";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<SpWho2Session>(query);
            }
        }
    }
}
