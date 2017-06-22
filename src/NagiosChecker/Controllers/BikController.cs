using Microsoft.AspNetCore.Mvc;
using NagiosChecker.Infrastructure;

namespace NagiosChecker.Controllers
{
    [Route("[controller]")]
    public class BikController : Controller
    {
        private readonly IBikService _bikSrv;

        public BikController(IBikService bikSrv)
        {
            _bikSrv = bikSrv;
        }

        // GET bik
        [HttpGet]
        public string Get()
        {
            return "BIK OK";
        }

        // GET bik/bikkitime
        [HttpGet("bikkitime")]
        public IActionResult BIK_KI_response_time()
        {
            string result = null;

            result = _bikSrv.GetBikKiRequestsStatusByTime();

            return Ok(result);
        }

        // GET bik/bikppercent
        [HttpGet("bikppercent")]
        public IActionResult BIK_Przeds_response_percent()
        {
            string result = null;

            result = _bikSrv.GetBikpRequestsStatusByNumber();

            return Ok(result);
        }

        // GET bik/bikptime
        [HttpGet("bikptime")]
        public IActionResult BIK_Przeds_response_time()
        {
            string result = null;

            result = _bikSrv.GetBikpRequestsStatusByTime();

            return Ok(result);
        }
    }
}
