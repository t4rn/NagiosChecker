namespace NagiosChecker.Infrastructure
{
    public interface ISlService
    {
        string GetSlQueue();
        string GetLongProcessingRequests(double minutes);
        string GetErrors(double days);
    }
}
