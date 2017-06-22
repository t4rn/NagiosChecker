using Microsoft.AspNetCore.Mvc;
using NagiosChecker.Infrastructure;
using System;

namespace NagiosChecker.Controllers
{
    [Route("[controller]")]
    public class KntController : Controller
    {
        private readonly ILogService _log;
        private readonly IKntService _kntSrv;

        public KntController(ILogService log, IKntService kntSrv)
        {
            _log = log;
            _kntSrv = kntSrv;
        }

        // GET knt
        [HttpGet]
        public string Get()
        {
            return "KNT OK";
        }

        // GET knt/queue
        [HttpGet("queue")]
        public IActionResult GetKntQueue()
        {
            string result = null;

            _log.Debug("GetKntQueue START");
            result = _kntSrv.GetKntQueue();
            _log.Debug("GetKntQueue END");

            return Ok(result);
        }

        // GET knt/pdf
        [HttpGet("pdf")]
        public IActionResult GePdfQueue()
        {
            string result = null;

            result = _kntSrv.GePdfQueue();

            return Ok(result);
        }

        // GET knt/annex
        [HttpGet("annex")]
        public IActionResult GetAnnexQueue(int id)
        {
            string result = null;

            result = _kntSrv.GetAnnexQueue();

            return Ok(result);
        }
    }
}
