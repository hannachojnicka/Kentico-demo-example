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
        int GetLastId(List<int> successIds, List<int> lastFaildIds, int lastId);
        List<int> GetSplitedIds(string ids);

    }
}
