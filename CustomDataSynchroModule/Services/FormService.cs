using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.Base;
using CMS.DataEngine;
using CMS.OnlineForms;
using CMS.OnlineForms.Types;
using CustomDataSynchroModule.Helpers;
using CustomDataSynchroModule.Interfaces;
using CustomDataSynchroModule.Mappers;
using CustomDataSynchroModule.Models.Dto;

namespace CustomDataSynchroModule.Services
{
    public class FormService : IFormService
    {
        private readonly ICoffeSampleFormMapper _coffeSampleFormMapper;
        public FormService(ICoffeSampleFormMapper coffeSampleFormMapper)
        {
            _coffeSampleFormMapper = coffeSampleFormMapper;
        }

        public List<CoffeSampleListDto> GetFormRecordedItems(ScheduledTaskResultDto lastScheduledTaskResult)
        {
            List<CoffeSampleListDto> records = new List<CoffeSampleListDto>();
            var data = new List<DancingGoatMvcCoffeeSampleListItem>();
            List<int> faildIds = new List<int>();

            if (!string.IsNullOrEmpty(lastScheduledTaskResult.FaildIds))
            {
                faildIds = GetSplitedIds(lastScheduledTaskResult.FaildIds);
            }

            if (faildIds.Any())
            {
                data.AddRange(BizFormItemProvider.GetItems<DancingGoatMvcCoffeeSampleListItem>()
                    .WhereIn("DancingGoatMvcCoffeeSampleListID", faildIds));
            }


            data.AddRange(BizFormItemProvider.GetItems<DancingGoatMvcCoffeeSampleListItem>()
                .WhereGreaterThan("DancingGoatMvcCoffeeSampleListID", lastScheduledTaskResult.LastId));


            if (data.Any())
            {
                records.AddRange(data.Select(p => _coffeSampleFormMapper.CreateCoffeSampleListDto(p)));
            }

            return records.DistinctBy(p=>p.Id).OrderBy(p => p.Id).ToList();

        }

        public List<int> GetSplitedIds(string ids)
        {

            return ids
                 .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.ToInteger(0))
                .ToList();

        }

        public int GetLastId(List<int> successIds, List<int> lastFaildIds, int lastId)
        {

            var validSuccessList = successIds.Except(lastFaildIds).ToList();

            return validSuccessList.Any() ? successIds.
                LastOrDefault() : lastId;
        }
    }
}

