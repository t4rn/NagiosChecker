using System;

namespace NagiosChecker.Infrastructure.Repositories
{
    public interface IBikRepository
    {
        /// <summary>
        /// Returns request time statistics
        /// </summary>
        Tuple<int, TimeSpan, TimeSpan> BikKiGetAvgAndMedianResponseTime();

        /// <summary>
        /// Returns request time statistics
        /// </summary>
        Tuple<int, TimeSpan, TimeSpan> BikPGetAvgAndMedianResponseTime();

        /// <summary>
        /// Returns request statistics
        /// </summary>
        /// <returns>all reports amount and received reports amount</returns>
        Tuple<long, long> BikPGetRequestsCountStatistics();
    }
}
