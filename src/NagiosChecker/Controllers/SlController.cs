using Microsoft.AspNetCore.Mvc;
using NagiosChecker.Infrastructure;
using System;

namespace NagiosChecker.Controllers
{
    [Route("[controller]")]
    public class SlController : Controller
    {
        private readonly ILogService _log;
        private readonly ISlService _slSrv;

        public SlController(ILogService log, ISlService slSrv)
        {
            _log = log;
            _slSrv = slSrv;
        }

        // GET: sl
        [HttpGet]
        public string Get()
        {
            return "SL OK";
        }

        // GET sl/queue
        [HttpGet("queue")]
        public IActionResult GetSlQueue(int id)
        {
            string result = null;

            _log.Debug("GetSlQueue START");
            result = _slSrv.GetSlQueue();
            _log.Debug($"GetSlQueue END -> {result}");

            return Ok(result);
        }

        [HttpGet("long")]
        public IActionResult GetLongProcessingRequests()
        {
            string result = null;

            _log.Debug("GetLongProcessingRequests START");
            result = _slSrv.GetLongProcessingRequests(30);
            _log.Debug($"GetLongProcessingRequests END -> {result}");

            return Ok(result);
        }

        [HttpGet("errors")]
        public IActionResult GetErrors()
        {
            string result = null;

            _log.Debug("GetErrors START");
            result = _slSrv.GetErrors(14);
            _log.Debug($"GetErrors END -> {result}");

            return Ok(result);
        }
    }
}
