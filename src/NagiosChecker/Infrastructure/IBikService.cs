namespace NagiosChecker.Infrastructure
{
    public interface IBikService
    {
        /// <summary>
        /// BIK P response percent
        /// </summary>
        string GetBikpRequestsStatusByNumber();

        /// <summary>
        /// BIK P response time
        /// </summary>
        string GetBikpRequestsStatusByTime();

        /// <summary>
        /// BIK KI response time
        /// </summary>
        string GetBikKiRequestsStatusByTime();
    }
}
