using project_be.Models;
using project_be.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace project_be.Controllers
{
    public class CalamityController : ApiController
    {
        private ICalamityService service;

        public CalamityController()
        {
            service = new CalamityServiceImp();
        }

        [HttpGet]
        public List<Calamity> GetAllCalamity()
        {
            return service.GetAllCalamity();
        }

        [HttpPost]
        public bool InsertCalamity(string name, string description, string location, DateTime dateStart, DateTime dateEnd, int numberOfFilming)
        {
            return service.InsertCalamity(name, description, location, dateStart, dateEnd, numberOfFilming);
        }

        [HttpPut]
        public bool UpdateCalamity(int id, string name, string description, string location, DateTime dateStart, DateTime dateEnd, int numberOfFilming)
        {
            return service.UpdateCalamity(id, name, description, location, dateStart, dateEnd, numberOfFilming);
        }

        [HttpDelete]
        public bool DeleteCalamity(int id)
        {
            return service.DeleteCalamity(id);
        }
        
    }
}
