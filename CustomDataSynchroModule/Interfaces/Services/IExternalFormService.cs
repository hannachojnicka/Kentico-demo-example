using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataSynchroModule.Models.Dto;
using CustomDataSynchroModule.Services;

namespace CustomDataSynchroModule.Interfaces
{
    public interface IExternalFormService : IService
    {
        bool SendFormToExternalServer(CoffeSampleListDto formDataItem, string urlAddressValue);
    }
}
