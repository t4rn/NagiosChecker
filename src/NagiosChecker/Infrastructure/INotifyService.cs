namespace NagiosChecker.Infrastructure
{
    public interface INotifyService
    {
        /// <summary> 
        ///  Adds error
        /// </summary>
        void AddException(string exMsg, string exStackTrace, string description);

        /// <summary> 
        ///  Adds error
        /// </summary>
        void AddError(string error);

        /// <summary> 
        ///  Adds message
        /// </summary>
        void AddMsg(string description);
    }
}
