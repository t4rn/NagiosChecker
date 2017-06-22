namespace NagiosChecker.DataAccess
{
    public abstract class BaseDAL
    {
        protected readonly string _connectionString;

        public BaseDAL(string cs)
        {
            _connectionString = cs;
        }
    }
}
