using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataSynchroModule.Models.Dto;

namespace CustomDataSynchroModule.Interfaces
{
    public interface IFormService : IService
    {
        List<CoffeSampleListDto> GetFormRecordedItems(ScheduledTaskResultDto lastScheduledTaskResult);
    }
}
