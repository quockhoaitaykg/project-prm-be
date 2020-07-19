using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_be.Services
{
    interface IToolService
    {
        bool InsertTool(string name, string image, string description, int quantity, bool status);

        bool UpdateTool(int id, string name, string image, string description, int quantity, bool status);

        bool DeleteTool(int id);

        List<Tool> GetAllTool();
    }
}
