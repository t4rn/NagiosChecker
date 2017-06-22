using System;

namespace NagiosChecker.Infrastructure
{
    public interface ILogService
    {
        void Error(string format, params object[] args);

        void Debug(string format, params object[] args);

        void Exception(Exception e, string description);

        void ErrorToFile(string err);
    }
}
