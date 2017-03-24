using GreenWichData.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenWichData.Data;


namespace GreenWichData.ServiceImpl
{
    public class AdminServiceImpl : AdminService
    {
        private GreenWichDBEntities dataContext = new GreenWichDBEntities();

        public void AddEvent(Event eventParam)
        {
            dataContext.Events.Add(eventParam);
            dataContext.SaveChanges();
        }

        public void AssaignStaffToEvent(Staff staffParam, Event eventParam)
        {
            Staff staff = dataContext.Staffs.Where(e => e.ID == staffParam.ID).FirstOrDefault();
            if (staff != null)
            {
                Event evnt = dataContext.Events.Where(e => e.ID == eventParam.ID).FirstOrDefault();
                Session session = dataContext.Sessions.Where(e => e.Assigned < e.Capacity).FirstOrDefault();
                if (evnt != null && session != null)
                {
                    session.Event.Staffs.Add(staff);
                    session.Assigned++;
                    dataContext.SaveChanges();
                }
            }
        }

        public void LimitCapacity(Session sessionParam, int capacity)
        {
            Session originalSession = dataContext.Sessions.Find(sessionParam.ID);
            originalSession.Capacity = capacity;
            dataContext.SaveChanges();
        }

        public void InserStaff(Staff staff)
        {
            dataContext.Staffs.Add(staff);
            dataContext.SaveChanges();
        }

        public void InserSession(Session session)
        {
            dataContext.Sessions.Add(session);
            dataContext.SaveChanges();
        }
    }
}
