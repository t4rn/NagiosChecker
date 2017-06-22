using Microsoft.AspNetCore.Http;
using NagiosChecker.Infrastructure;
using NLog;
using System;

namespace NagiosChecker.Services
{
    public class KrisLogger : ILogService
    {
        private readonly INotifyService _notify;
        private readonly Logger _log;
        private readonly IHttpContextAccessor _accessor;
        private readonly string _ip;

        public KrisLogger(INotifyService notify, IHttpContextAccessor accessor)
        {
            _accessor = accessor;
            _ip = _accessor?.HttpContext?.Connection.RemoteIpAddress?.ToString();
            _notify = notify;
            _log = LogManager.GetLogger("LOG");
        }
        public void Debug(string format, params object[] args)
        {
            _log.Debug(message: format, args: args);
        }

        public void Error(string format, params object[] args)
        {
            _log.Error(message: format, args: args);
        }

        public void Exception(Exception ex, string description)
        {
            description = $"ip = {_ip} | {description}";
            _log.Error("Ex: desc = {0} | msg = {1} | st = {2}",
                description, ex.Message, ex.StackTrace);
            _notify.AddException(ex.Message, ex.StackTrace, description);
        }

        public void ErrorToFile(string err)
        {
            _log.Error($"ErrorToFile: {err}");
        }
    }
}
