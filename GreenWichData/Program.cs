using GreenWichData.Data;
using GreenWichData.ServiceImpl;
using GreenWichData.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWichData
{
    class Program
    {
        static void Main(string[] args)
        {

            GreenWichDBEntities dataContext = new GreenWichDBEntities();
            AdminServiceImpl service = new AdminServiceImpl();
            Session session = dataContext.Sessions.Where(e => e.Event_ID == 1).FirstOrDefault();
            #region staffService
            //Event evnt = dataContext.Events.Where(e => e.Event_Code == "PHP211").FirstOrDefault();
            //Staff staff = new Staff();
            //staff.Name = "Istiak Ratul";
            //staff.Organization = "CDIP";
            //staff.Designation = "IT Executive";
            //service.InserStaff(staff);
            //service.AssaignStaffToEvent(staff, evnt);
            #endregion

            #region sessionService
            //DateTime timeInstance = new DateTime(2017, 04, 12,10,0,0);
            //Session session = new Session();
            //session.Date = timeInstance.Date;
            //session.Time = timeInstance.TimeOfDay;
            //session.Event_Content = "Test Content";
            //session.Capacity = 30;
            //session.Event_ID = 1;


            //service.InserSession(session); 
            #endregion
            //service.LimitCapacity(session,40);




        }
    }
}
