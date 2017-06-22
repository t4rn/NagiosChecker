namespace NagiosChecker.DataModel
{
    public class ApiError
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public string stackTrace { get; set; }

        public ApiError(string message)
        {
            Message = message;
            IsError = true;
        }
    }
}
