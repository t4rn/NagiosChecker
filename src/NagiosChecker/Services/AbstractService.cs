using NagiosChecker.DataModel;
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

        protected StatusForNagios PrepareStatus(int value, int warningThreshold, int errorThreshold)
        {
            return value < warningThreshold ? StatusForNagios.OK : value < errorThreshold ? StatusForNagios.WARNING : StatusForNagios.ERROR;
        }

        /// <summary>
        /// Zwraca string w postaci {0};{1}
        /// </summary>
        protected string PrepareResult(StatusForNagios status, string message)
        {
            return string.Format("{0};{1}", (int)status, message);
        }
    }
}
