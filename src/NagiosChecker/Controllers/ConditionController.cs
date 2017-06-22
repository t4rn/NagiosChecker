using Microsoft.AspNetCore.Mvc;
using NagiosChecker.Infrastructure;
using System;

namespace NagiosChecker.Controllers
{
    [Route("[controller]")]
    public class ConditionController : Controller
    {
        private readonly ILogService _log;
        private readonly IKntService _kntSrv;

        public ConditionController(ILogService log, IKntService kntSrv)
        {
            _log = log;
            _kntSrv = kntSrv;
        }

        // GET: condition
        [HttpGet]
        public string Get()
        {
            return "Condition OK";
        }

        // GET condition/queue
        [HttpGet("queue")]
        public IActionResult GetConditionsQueue(int id)
        {
            string result = null;

            result = _kntSrv.GetConditionsQueue();

            return Ok(result);
        }
    }
}
