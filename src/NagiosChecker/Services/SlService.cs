using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure;
using NagiosChecker.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NagiosChecker.Services
{
    public class SlService : AbstractService, ISlService
    {
        private readonly ISlRepository _slRepo;

        public SlService(ILogService log, ISlRepository slRepo) : base(log)
        {
            _slRepo = slRepo;
        }

        public string GetSlQueue()
        {
            string result = null;
            List<TypeCount> list = _slRepo.CountPendingRequests();

            result = PrepareSlQueue(list);

            return result;
        }

        private string PrepareSlQueue(List<TypeCount> list)
        {
            string result = null;

            // default error
            int statusForNagios = 0;
            string message = string.Empty;

            if (list?.Count > 0)
            {
                int waiting = list.Find(x => x.Type == "WAIT").Count;
                int phase1 = list.Find(x => x.Type == "PHASE1").Count;
                int phase2 = list.Find(x => x.Type == "PHASE2").Count;
                int sum = waiting + phase1 + phase2;

                if (waiting == 0 && phase1 < 2 && phase2 < 2)
                {
                    statusForNagios = 0;
                }
                else if (sum < 5)
                {
                    statusForNagios = 1;
                }
                else
                {
                    statusForNagios = 2;
                }

                message = string.Format("Waiting = '{0}', Phase1 = '{1}' Phase2 = '{2}'",
                    waiting, phase1, phase2);
            }
            else
            {
                statusForNagios = 2;
                message = "Empty data from DB";
            }

            result = $"{statusForNagios};{message}";

            return result;
        }

        public string GetLongProcessingRequests(double minutes)
        {
            string result = null;
            DateTime sinceDate = DateTime.Now.AddMinutes(-minutes);
            List<TypeCount> list = _slRepo.CountLongProcessingReqeuests(sinceDate);

            result = PrepareLongProcessingRequestResult(list);
            return result;
        }

        private string PrepareLongProcessingRequestResult(List<TypeCount> list)
        {
            string result = null;

            // default error
            int statusForNagios = 0;
            string message = string.Empty;

            if (list?.Count > 0)
            {
                int phase1 = list.Find(x => x.Type == "PHASE1").Count;
                int phase2 = list.Find(x => x.Type == "PHASE2").Count;
                int sum = phase1 + phase2;

                if (sum == 0)
                {
                    statusForNagios = 0;
                }
                else if (sum <= 2)
                {
                    statusForNagios = 1;
                }
                else
                {
                    statusForNagios = 2;
                }

                message = string.Format($"Phase1 = '{phase1}' Phase2 = '{phase2}'");
            }
            else
            {
                statusForNagios = 2;
                message = "Empty data from DB";
            }

            result = $"{statusForNagios};{message}";

            return result;
        }

        public string GetErrors(double days)
        {
            string result = null;

            DateTime sinceDate = DateTime.Now.AddDays(-days);

            List<DateTime> errors = _slRepo.GetErrors(sinceDate);

            result = PrepareErrorsResult(errors, sinceDate);

            return result;
        }

        private string PrepareErrorsResult(List<DateTime> errors, DateTime sinceDate)
        {
            string result;

            int statusForNagios;

            string message = $"Errors = '{errors?.Count}' since '{sinceDate.ToString("yyyy-MM-dd")}'";

            if (errors?.Count > 0)
            {
                errors = errors.OrderByDescending(x => x).ToList();
                message = $"{message}. Last error occured on '{errors.FirstOrDefault()}'";
            }

            if (errors.Count == 0)
            {
                statusForNagios = 0;
            }
            else if (errors.Count > 0 && errors.Count < 2)
            {
                statusForNagios = 1;
            }
            else
            {
                statusForNagios = 2;
            }

            result = $"{statusForNagios};{message}";

            return result;
        }
    }
}
