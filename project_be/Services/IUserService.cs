﻿
using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_be.Services
{
    interface IUserService
    {
        User CheckLoginAdmin(String email, String password);
    }
}
