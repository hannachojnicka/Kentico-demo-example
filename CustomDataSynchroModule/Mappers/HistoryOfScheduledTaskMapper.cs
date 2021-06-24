using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataSynchroModule.Interfaces;
using CustomDataSynchroModule.Models.Dto;
using CustomDataSynchronization;

namespace CustomDataSynchroModule.Mappers
{
    public class HistoryOfScheduledTaskMapper : IHistoryOfScheduledTaskMapper
    {
        public HistoryOfScheduledTaskInfo CreateHistoryOfScheduledTaskInfo(ScheduledTaskResultDto scheduledTaskResultDto)
        {
            return new HistoryOfScheduledTaskInfo()
            {
                TaskRunTime = scheduledTaskResultDto.Date,
                Result = scheduledTaskResultDto.Result,
                IDs = scheduledTaskResultDto.Ids,
                LastID = scheduledTaskResultDto.LastId,
                FailIdIDs = scheduledTaskResultDto.FaildIds,
                NumberOfSuccessIDs = scheduledTaskResultDto.NumberOfSuccessIDs
            };
        }
    }
}
