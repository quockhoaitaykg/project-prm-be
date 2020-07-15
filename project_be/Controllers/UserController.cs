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

        [HttpGet]
        public User CheckLoginAdmin(String email, String password)
        {
            return service.CheckLoginAdmin(email, password);
        }

    }
}
