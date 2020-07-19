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
    public class MovieToolController : ApiController
    {
        private IMovieToolService service;

        public MovieToolController()
        {
            service = new MovieToolServiceImp();
        }

        [HttpPost]
        public bool InsertToolMovie(int calId, int toolId, int quantity)
        {
            return service.InsertMovieTool(calId, toolId, quantity);
        }

        [HttpGet]
        public List<CalamityTool> GetAllTool()
        {
            return service.GetAllTool();
        }

    }
}
