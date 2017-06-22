using NagiosChecker.Infrastructure;

namespace NagiosChecker.Services
{
    public class AbstractService
    {
        protected readonly ILogService log;

        public AbstractService(ILogService log)
        {
            this.log = log;
        }
    }
}
