using GreenWichData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenWichData.ServiceImpl;

namespace GreenWichWeb.Controllers
{
    public class AdminController : Controller
    {
         AdminServiceImpl service = new AdminServiceImpl();
         GreenWichDBEntities dataContext = new GreenWichDBEntities();

        [HttpGet]
        public ActionResult CreateEvent()
        {
            ViewData["StaffIDList"]=new SelectList(dataContext.Staffs,"ID","Name");
            
            return View();
        }

        [HttpPost]
        public ActionResult CreateEvent(Event event1)
        {
            service.AddEvent(event1);
            return View();
        }
        public ActionResult testAssembly()
        {
            Event e = new Event();
            e.Name = "test";
            service.AddEvent(e);
            return View();
        }
    }
}
