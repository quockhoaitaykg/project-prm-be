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
    public class UserController : ApiController
    {
        private IUserService service;

        public UserController()
        {
            service = new UserServiceImp();
        }

        [HttpPost]
        public String CheckLoginAdmin(string email, string password)
        {
            return service.CheckLoginAdmin(email, password);
        }

        [HttpPost]
        public bool InsertAdmin(string email, string password)
        {
            return service.InsertAdmin(email, password);
        }

    }
}
