using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.OnlineForms.Types;
using CustomDataSynchroModule.Interfaces;
using CustomDataSynchroModule.Models.Dto;
using CustomDataSynchronization;

namespace CustomDataSynchroModule.Mappers
{
    public class CoffeSampleFormMapper : ICoffeSampleFormMapper
    {
        public CoffeSampleListDto CreateCoffeSampleListDto(DancingGoatMvcCoffeeSampleListItem dancingGoatMvcCoffeeSampleListItem)
        {
            return new CoffeSampleListDto()
            {
                Id = dancingGoatMvcCoffeeSampleListItem.ItemID,
                State = dancingGoatMvcCoffeeSampleListItem.State,
                Email = dancingGoatMvcCoffeeSampleListItem.Email,
                ZIPCode = dancingGoatMvcCoffeeSampleListItem.ZIPCode,
                City = dancingGoatMvcCoffeeSampleListItem.City,
                Country = dancingGoatMvcCoffeeSampleListItem.Country,
                FirstName = dancingGoatMvcCoffeeSampleListItem.FirstName,
                LastName = dancingGoatMvcCoffeeSampleListItem.LastName
            };
        }
    }
}
