using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.OnlineForms.Types;
using CustomDataSynchroModule.Mappers;
using CustomDataSynchroModule.Models.Dto;

namespace CustomDataSynchroModule.Interfaces
{
    public interface ICoffeSampleFormMapper : IMapper
    {
        CoffeSampleListDto CreateCoffeSampleListDto(
            DancingGoatMvcCoffeeSampleListItem dancingGoatMvcCoffeeSampleListItem);
    }

}
