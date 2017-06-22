using NagiosChecker.DataModel;
using System.Collections.Generic;

namespace NagiosChecker.Infrastructure.Repositories
{
    public interface IRexsRepository
    {
        /// <summary>
        /// Returns a list of credit aaplications waiting for processing
        /// </summary>
        List<TypeCount> CountApplicationsOnStatus();

        /// <summary>
        /// Returns the amount of pending conditions
        /// </summary>
        int CountPendingConditions();

        /// <summary>
        /// Returns the amount of pending annexes
        /// </summary>
        int CountPendingAnnexes();
    }
}