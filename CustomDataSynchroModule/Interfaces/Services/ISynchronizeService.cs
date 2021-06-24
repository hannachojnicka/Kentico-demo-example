using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataSynchroModule.Interfaces.Services
{
    public interface ISynchronizeService : IService
    {
        string RunSynchronization();
    }
}
