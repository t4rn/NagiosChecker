using NagiosChecker.DataModel;
using System.Collections.Generic;

namespace NagiosChecker.Infrastructure.Repositories
{
    public interface IMsSqlRepository
    {
        IEnumerable<SpWho2Session> GetSessions();
    }
}
