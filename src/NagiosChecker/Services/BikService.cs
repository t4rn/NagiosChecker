using NagiosChecker.Infrastructure;
using NagiosChecker.Infrastructure.Repositories;
using System;

namespace NagiosChecker.Services
{
    public class BikService : AbstractService, IBikService
    {
        private readonly IBikRepository _bikDAL;

        public BikService(ILogService log, IBikRepository bikRepo) : base(log)
        {
            _bikDAL = bikRepo;
        }

        /// <summary>
        /// BIK P response percent
        /// </summary>
        public string GetBikpRequestsStatusByNumber()
        {
            string status, message;

            var x = _bikDAL.BikPGetRequestsCountStatistics();
            double received = x.Item1;
            double all = x.Item2;
            if (all > 0)
            {
                message = string.Format("requests: {0}, received reports: {1}, not received percent: {2}%", 
                    all, received, Math.Round(100 - received / all * 100, 2));
            }
            else
            {
                message = string.Format("no requests");
            }

            if (all < 10)
            {
                status = "0";
            }
            else if ((received / all) > 0.95)
            {
                status = "0";
            }
            else if ((received / all) > 0.80)
            {
                status = "1";
            }
            else
            {
                status = "2";
            }

            return status + ";" + message;
        }

        /// <summary>
        /// BIK P response time
        /// </summary>
        public string GetBikpRequestsStatusByTime()
        {
            string status, message;

            var x = _bikDAL.BikPGetAvgAndMedianResponseTime();
            long number = x.Item1;
            TimeSpan avg = x.Item2;
            TimeSpan median = x.Item3;

            message = string.Format("sample size: {0}, avg: {1}, median: {2}", number, avg, median);

            if (avg < new TimeSpan(0, 0, 5) && median < new TimeSpan(0, 0, 5))
            {
                status = "0";
            }
            else if (avg < new TimeSpan(0, 0, 15) && median < new TimeSpan(0, 0, 15))
            {
                status = "1";
            }
            else
            {
                status = "2";
            }

            return status + ";" + message;
        }

        /// <summary>
        /// BIK KI response time
        /// </summary>
        public string GetBikKiRequestsStatusByTime()
        {
            string status, message;

            var x = _bikDAL.BikKiGetAvgAndMedianResponseTime();
            long number = x.Item1;
            TimeSpan avg = x.Item2;
            TimeSpan median = x.Item3;

            message = string.Format("sample size: {0}, avg: {1}, median: {2}", number, avg, median);

            if (avg < new TimeSpan(0, 0, 10) && median < new TimeSpan(0, 0, 10))
            {
                status = "0";
            }
            else if (avg < new TimeSpan(0, 0, 17) && median < new TimeSpan(0, 0, 17))
            {
                status = "1";
            }
            else
            {
                status = "2";
            }

            return status + ";" + message;
        }
    }
}
