﻿using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
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
        public String CheckLoginAdmin(string email, string password)
        {
            String user = db.Users.Where(x => x.Email == email && x.Password == password).Select(x => x.Role).SingleOrDefault();
            if (user != null)
            {
                return user;
            }
            return "error";
           
        }

        public bool InsertAdmin(string email, string password)
        {
            try
            {
                User user = new User();
                user.Email = email;
                user.Password = password;
                user.Role = "Admin";
                user.DelFlg = false;
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}