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
    public class ToolController : ApiController
    {
        private IToolService service;

        public ToolController()
        {
            service = new ToolServiceImp();
        }

        [HttpGet]
        public List<Tool> GetAllTool()
        {
            return service.GetAllTool();
        }
        [HttpPost]
        public bool InsertTool(string name, string image, string description, int quantity, string status)
        {
            return service.InsertTool(name, image, description, quantity, status);
        }
        [HttpDelete]
        public bool DeleteTool(int id)
        {
            return service.DeleteTool(id);
        }

        public bool UpdateTool(int id, string name, string image, string description, int quantity, string status)
        {
            return service.UpdateTool(id, name, image, description, quantity, status);
        }
    }
}
