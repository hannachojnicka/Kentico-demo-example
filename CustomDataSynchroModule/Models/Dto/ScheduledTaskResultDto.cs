using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataSynchroModule.Models.Dto
{
    public class ScheduledTaskResultDto : IDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Ids { get; set; }
        public string FaildIds { get; set; }
        public string Result { get; set; }
        public int NumberOfSuccessIDs { get; set; }
        public int LastId { get; set; }
    }
}
