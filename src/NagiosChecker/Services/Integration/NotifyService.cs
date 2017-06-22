using Microsoft.Extensions.Options;
using NagiosChecker.DataModel;
using NagiosChecker.Infrastructure;
using SoapNotify;
using System;

namespace NagiosChecker.Services.Integration
{
    public class NotifyService : INotifyService
    {
        private DictionaryItemDTO _system;
        private string _hash;

        public NotifyService(IOptions<AppSettings> settings)
        {
            _system = new DictionaryItemDTO()
            {
                Code = settings.Value.NotifyName
            };
            _hash = "123";
        }

        /// <summary>
        /// Adds error
        /// </summary>
        public void AddException(string exMsg, string exStackTrace, string description)
        {
            ErrorDTO error = new ErrorDTO()
            {
                ErrorMessage = exMsg,
                StackTrace = exStackTrace,
                Description = description,
                OccuranceDate = DateTime.Now,
                System = _system
            };

            AddNotification(error);
        }

        /// <summary> 
        /// Adds error
        /// </summary>
        public void AddError(string errorDesc)
        {
            ErrorDTO error = new ErrorDTO()
            {
                ErrorMessage = errorDesc,
                OccuranceDate = DateTime.Now,
                System = _system
            };

            AddNotification(error);
        }

        /// <summary> 
        /// Adds message
        /// </summary>
        public void AddMsg(string description)
        {
            MsgLogDTO msg = new MsgLogDTO()
            {
                Description = description,
                OccuranceDate = DateTime.Now,
                System = _system
            };

            AddNotification(msg);
        }

        /// <summary> 
        /// Adds notification to WS
        /// </summary>
        private async void AddNotification(NotificationDTO notification)
        {
            try
            {
                NotifyClient client = new NotifyClient();
                ResultDTO r = await client.AddNotificationAsync(notification, _hash);
                await client.CloseAsync();
            }
            catch (Exception ex)
            {
                new KrisLogger(null, null).ErrorToFile(
                    string.Format("[AddNotification] ERROR podczas zapisu notificationa, Msg = '{0}' | StackTrace = '{1}'",
                    ex.Message, ex.StackTrace));
            }
        }
    }
}
