using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure;
using NagiosChecker.Infrastructure.Repositories;
using System.Collections.Generic;

namespace NagiosChecker.Services
{
    public class KntService : AbstractService, IKntService
    {
        private readonly IRexsRepository _rexsRepo;
        private readonly IKntRepository _kntRepo;

        public KntService(ILogService log, IRexsRepository rexsRepo, IKntRepository kntRepo)
            : base(log)
        {
            _rexsRepo = rexsRepo;
            _kntRepo = kntRepo;
        }


        public string GePdfQueue()
        {
            int statusForNagios = 0;
            string result, message;

            int depth = _kntRepo.GetPdfQueueDepth();
            message = string.Format("PDF Queue depth = '{0}'", depth);

            statusForNagios = depth < 10 ? 0 : depth < 100 ? 1 : 2;

            result = string.Format("{0};{1}", statusForNagios, message);

            return result;
        }

        public string GetKntQueue()
        {
            int statusForNagios = 0;
            string result = string.Empty;
            string message = string.Empty;
            List<TypeCount> list = _rexsRepo.CountApplicationsOnStatus();

            int regCount = list.Find(x => x.Type == "register").Count;
            int agrCount = list.Find(x => x.Type == "agreement").Count;
            int docsub = list.Find(x => x.Type == "docsub").Count;
            int sum = regCount + agrCount + docsub;

            statusForNagios = sum < 5 ? 0 : sum < 20 ? 1 : 2;

            message = string.Format("Register = '{0}', Agreement = '{1}', DocSub = '{2}'", regCount, agrCount, docsub);

            result = string.Format("{0};{1}", statusForNagios, message);

            return result;
        }

        public string GetConditionsQueue()
        {
            int statusForNagios = 0;
            string result, message;

            int depth = _rexsRepo.CountPendingConditions();
            message = string.Format("Pending Conditions = '{0}'", depth);

            statusForNagios = depth < 300 ? 0 : depth < 500 ? 1 : 2;

            result = string.Format("{0};{1}", statusForNagios, message);

            return result;
        }

        public string GetAnnexQueue()
        {
            int statusForNagios = 0;
            string result, message;

            int depth = _rexsRepo.CountPendingAnnexes();
            message = string.Format("Pending Annexes = '{0}'", depth);

            statusForNagios = depth < 5 ? 0 : depth < 10 ? 1 : 2;

            result = string.Format("{0};{1}", statusForNagios, message);

            return result;
        }
    }
}
