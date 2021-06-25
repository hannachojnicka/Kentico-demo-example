using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataSynchroModule.Interfaces;
using CustomDataSynchroModule.Models.Dto;
using CustomDataSynchronization;

namespace CustomDataSynchroModule.Services
{
    public class HistoryOfScheduledTaskService : IHistoryOfScheduledTaskSerivce
    {
        private readonly IHistoryOfScheduledTaskMapper _historyOfScheduledTaskMapper;

        public HistoryOfScheduledTaskService(IHistoryOfScheduledTaskMapper historyOfScheduledTaskMapper)
        {

            _historyOfScheduledTaskMapper = historyOfScheduledTaskMapper;

        }

        public ScheduledTaskResultDto GetLastSynchronizedItem()
        {
            var lastElement = HistoryOfScheduledTaskInfoProvider.GetHistoryOfScheduledTasks().LastOrDefault();
            if (lastElement != null)
            {
                return new ScheduledTaskResultDto() { LastId = lastElement.LastID, FaildIds = lastElement.FailIdIDs };
            }

            return new ScheduledTaskResultDto() { FaildIds = ""} ;
        }

        public void AddHistoryOfScheduledTask(ScheduledTaskResultDto scheduledTaskResult)
        {
            var item = _historyOfScheduledTaskMapper.CreateHistoryOfScheduledTaskInfo(scheduledTaskResult);
            HistoryOfScheduledTaskInfoProvider.SetHistoryOfScheduledTaskInfo(item);

        }


    }
}
