using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_be.Services
{
    interface IMovieToolService
    {
        bool InsertMovieTool(int calId, int toolId, int quantity);

        List<CalamityTool> GetAllTool();
    }
}
