using System;
using System.Net.Http;
using CMS;
using CMS.EventLog;
using CMS.Scheduler;
using CustomDataSynchroModule.Interfaces.Services;
using CustomDataSynchroModule.Mappers;
using CustomDataSynchroModule.Services;



namespace CustomDataSynchroModule
{
    public class SynchronizeFormItemsScheduledTask : ITask
    {
        private readonly ISynchronizeService _synchronizationService;
        public SynchronizeFormItemsScheduledTask()
        {
            _synchronizationService = new SynchronizeService(new ExternalFormService(
                new HttpClientService(
                    new HttpClient())), new FormService(new CoffeSampleFormMapper()), new HistoryOfScheduledTaskService(new HistoryOfScheduledTaskMapper()));
        }



        public string Execute(TaskInfo ti)
        {
            string result;
            try
            {
                result = _synchronizationService.RunSynchronization();
            }
            catch (Exception ex)
            {
                result = ex.Message;
                EventLogProvider.LogException("SynchronizeFormItemsScheduledTask", "TaskExecutionFailure", ex);
            }
            // Returns a null value to indicate that the task executed successfully
            // Return an error message string with details in cases where the execution fails
            return result;
        }
    }
}
