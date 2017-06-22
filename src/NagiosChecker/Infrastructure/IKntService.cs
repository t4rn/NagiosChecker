namespace NagiosChecker.Infrastructure
{
    public interface IKntService
    {
        /// <summary>
        /// Returns pdf queue depth
        /// </summary>
        string GePdfQueue();

        /// <summary>
        /// Returns the length of pending credit applications queue
        /// </summary>
        string GetKntQueue();

        /// <summary>
        /// Returns conditions queue depth
        /// </summary>
        string GetConditionsQueue();

        /// <summary>
        /// Returns annex queue depth
        /// </summary>
        string GetAnnexQueue();
    }
}
