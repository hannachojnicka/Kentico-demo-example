using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DataEngine;
using CMS.EventLog;
using CMS.Helpers;
using CMS.SiteProvider;
using CustomDataSynchroModule.Interfaces;
using CustomDataSynchroModule.Interfaces.Services;
using CustomDataSynchroModule.Models.Dto;

namespace CustomDataSynchroModule.Services
{
    public class SynchronizeService : ISynchronizeService
    {
        private readonly IExternalFormService _externalFormService;
        private readonly IFormService _formService;
        private readonly IHistoryOfScheduledTaskSerivce _historyOfScheduledTaskSerivce;
        public SynchronizeService(IExternalFormService externalFormService, IFormService formService, IHistoryOfScheduledTaskSerivce historyOfScheduledTaskSerivce)
        {
            _externalFormService = externalFormService;
            _formService = formService;
            _historyOfScheduledTaskSerivce = historyOfScheduledTaskSerivce;
        }

        public string RunSynchronization()
        {
            StringBuilder result = new StringBuilder();

            var lastItem = new ScheduledTaskResultDto();
            var lastFaildIds = new List<int>();
            var successIds = new List<int>();
            var failIds = new List<int>();

            try
            {
                lastItem = _historyOfScheduledTaskSerivce.GetLastSynchronizedItem();
                lastFaildIds = _formService.GetSplitedIds(lastItem.FaildIds);
                var items = _formService.GetFormRecordedItems(lastItem);
                var urlAPI = SettingsKeyInfoProvider.GetValue(Constants.API_URL_SYNCHROFORM_SETTINGS_KEY, SiteContext.CurrentSiteID);


                items.ForEach((item) =>
                {
                    try
                    {
                        bool isSuccess = _externalFormService.SendFormToExternalServer(item, urlAPI);
                        if (isSuccess)
                        {
                            successIds.Add(item.Id);
                        }
                        else
                        {
                            failIds.Add(item.Id);
                            result.AppendLine($"ItemId {item.Id} - The server is unable to connect.");
                        }
                    }
                    catch (Exception ex)
                    {
                        result.AppendLine($"Form item id {item.Id} synchro failed. Messege: {ex}");
                    }

                });

                result.AppendLine($"{successIds.Count} form items successfully sent, {failIds.Count} failed.");



            }
            catch (Exception ex)
            {
                result.AppendLine($"Task failed. Messege: {ex}");
            }

            ScheduledTaskResultDto scheduledTaskResult = new ScheduledTaskResultDto()
            {
                Date = DateTime.Now,
                Ids = successIds.Select(p => p.ToString()).Join(","),
                LastId = _formService.GetLastId(successIds, lastFaildIds, lastItem.LastId),
                Result = result.ToString(),
                FaildIds = failIds.Select(p => p.ToString()).Join(","),
                NumberOfSuccessIDs = successIds.Count
            };

            _historyOfScheduledTaskSerivce.AddHistoryOfScheduledTask(scheduledTaskResult);
            return result.ToString();
        }

      


    }
}
