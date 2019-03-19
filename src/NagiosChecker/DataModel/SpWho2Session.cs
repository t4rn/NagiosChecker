namespace NagiosChecker.DataModel
{
    public class SpWho2Session
    {
        public int SPID { get; set; }
        public string Status { get; set; }
        public string Login { get; set; }
        public string HostName { get; set; }
        public string BlkBy { get; set; }
        public string DBName { get; set; }
        public string Comman { get; set; }
        public long CPUTime { get; set; }
        public long DiskIO { get; set; }
        public string LastBatch { get; set; }
        public string ProgramName { get; set; }
        public int REQUESTID { get; set; }
    }
}
