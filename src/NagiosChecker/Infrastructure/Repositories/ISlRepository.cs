using NagiosChecker.DataModel;
using System.Collections.Generic;
using System;

namespace NagiosChecker.Infrastructure.Repositories
{
    public interface ISlRepository
    {
        /// <summary>
        /// Returns a list of requests waiting for processing
        /// </summary>
        List<TypeCount> CountPendingRequests();

        /// <summary>
        /// Returns list of long processing requests
        /// </summary>
        List<TypeCount> CountLongProcessingReqeuests(DateTime sinceDate);

        /// <summary>
        /// Returns dates of errors which occured since specified date
        /// </summary>
        List<DateTime> GetErrors(DateTime sinceDate);
    }
}
