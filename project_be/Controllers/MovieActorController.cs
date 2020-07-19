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
    public class MovieActorController : ApiController
    {
        private IMovieActorService service;

        public MovieActorController()
        {
            service = new MovieActorServiceImp();
        }

        [HttpPost]
        public bool InsertActorMovie(int calId, int actorId, string role)
        {
            return service.InsertActorMovie(calId, actorId, role);
        }

        [HttpGet]
        public List<CalamityActor> GetAll()
        {
            return service.GetAll();
        }
    }
}
