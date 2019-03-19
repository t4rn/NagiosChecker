using Microsoft.AspNetCore.Mvc;
using NagiosChecker.Infrastructure;

namespace NagiosChecker.Controllers
{
    [Route("[controller]")]
    public class MsSqlController : Controller
    {
        private readonly ILogService _log;
        private readonly IMsSqlService _msSqlService;

        public MsSqlController(ILogService log, IMsSqlService msSqlService)
        {
            _log = log;
            _msSqlService = msSqlService;
        }

        // GET mssql
        [HttpGet]
        public string Get()
        {
            return "MSSQL OK";
        }

        // GET mssql/locks
        [HttpGet("locks")]
        public IActionResult GetLocks()
        {
            string result = null;

            _log.Debug("GetLocks START");
            result = _msSqlService.GetLocks();
            _log.Debug($"GetLocks END -> {result}");

            return Ok(result);
        }
    }
}
