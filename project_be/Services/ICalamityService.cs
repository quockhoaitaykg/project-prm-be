using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_be.Services
{
    interface ICalamityService
    {
        bool InsertCalamity(string name, string description, string location, DateTime dateStart, DateTime dateEnd, int numberOfFilming);

        bool UpdateCalamity(int id, string name, string description, string location, DateTime dateStart, DateTime dateEnd, int numberOfFilming);

        bool DeleteCalamity(int id);

        List<Calamity> GetAllCalamity();
    }
}
