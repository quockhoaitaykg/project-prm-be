using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace project_be.Services
{
    public class UserServiceImp : IUserService
    {
        private projectEntities db;

        public UserServiceImp()
        {
            this.db = new projectEntities();
        }
        public User CheckLoginAdmin(string email, string password)
        {
                User user = db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
                


                return user;
           
        }
    }
}