using GreenWichData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWichData.ServiceInterface
{
    interface AdminService
    {
         void AddEvent(Event eventParam);
         void AssaignStaffToEvent(Staff staffParam, Event eventParam);
         void LimitCapacity(Session sessionParam, int capacity);
        

    }
}
