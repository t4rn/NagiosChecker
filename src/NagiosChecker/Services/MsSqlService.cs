using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure;
using NagiosChecker.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NagiosChecker.Services
{
    public class MsSqlService : AbstractService, IMsSqlService
    {
        private readonly IMsSqlRepository _msSqlRepo;

        public MsSqlService(ILogService log, IMsSqlRepository msSqlRepo) : base(log)
        {
            _msSqlRepo = msSqlRepo;
        }

        public string GetLocks()
        {
            string result = null;

            IEnumerable<SpWho2Session> sessions = _msSqlRepo.GetSessions();

            IEnumerable<SpWho2Session> blockers = GetBlockers(sessions);

            if (!blockers.Any())
                result = PrepareResult(StatusForNagios.OK, $"{sessions.Count()} sessions without locks");
            else
                result = PrepareResult(StatusForNagios.ERROR, $"Blockers: {string.Join(";", blockers.Select(x => x.Login))} in {sessions.Count()} sessions");

            return result;
        }

        public IEnumerable<SpWho2Session> GetBlockers(IEnumerable<SpWho2Session> sessions)
        {
            var blockers = new List<SpWho2Session>();

            var blockedSessions = new List<SpWho2Session>();

            foreach (SpWho2Session session in sessions)
            {
                // trim default empty value = " ."
                session.BlkBy = session.BlkBy.Replace(" .", "").Trim();

                if (!string.IsNullOrWhiteSpace(session.BlkBy))
                    blockedSessions.Add(session);
            }

            if (blockedSessions.Any())
            {
                var groupedByBlockId = blockedSessions.GroupBy(x => x.BlkBy);

                log.Debug($"Blocked '{blockedSessions.Count()}' sessions by '{groupedByBlockId.Count()} blockers");

                foreach (var grouped in groupedByBlockId)
                {
                    // every item in 'grouped' has the same BlkBy ID
                    SpWho2Session blockedSession = grouped.First();
                    SpWho2Session blocker = GetBlocker(blockedSession, sessions);

                    if (!blockers.Contains(blocker))
                        blockers.Add(blocker);
                }
            }

            return blockers;
        }

        private SpWho2Session GetBlocker(SpWho2Session session, IEnumerable<SpWho2Session> allSessions)
        {
            if (string.IsNullOrWhiteSpace(session.BlkBy))
            {
                // current session isn't blocked by any other -> so it's a blocker! :D
                return session;
            }
            else
            {
                var blocker = allSessions.Single(x => x.SPID == Convert.ToInt32(session.BlkBy));
                return GetBlocker(blocker, allSessions);
            }
        }
    }
}
