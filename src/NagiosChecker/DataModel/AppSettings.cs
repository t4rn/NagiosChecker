namespace NagiosChecker.DataModel
{
    public class AppSettings
    {
        public string NotifyName { get; set; }
        public ConnectionStringList ConnectionStrings { get; set; }
    }

    public class ConnectionStringList
    {
        public string csMain { get; set; }
    }
}