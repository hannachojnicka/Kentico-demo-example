using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataSynchroModule.Mappers;
using CustomDataSynchroModule.Models.Dto;
using CustomDataSynchronization;

namespace CustomDataSynchroModule.Interfaces
{
    public interface IHistoryOfScheduledTaskMapper : IMapper
    {
        HistoryOfScheduledTaskInfo CreateHistoryOfScheduledTaskInfo(ScheduledTaskResultDto scheduledTaskResultDto);
    }
}
