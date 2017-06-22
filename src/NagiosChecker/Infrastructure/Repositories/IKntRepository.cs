namespace NagiosChecker.Infrastructure.Repositories
{
    public interface IKntRepository
    {
        /// <summary>
        /// Returns pdf queue depth
        /// </summary>
        int GetPdfQueueDepth();
    }
}
