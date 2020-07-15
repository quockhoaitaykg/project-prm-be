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
    public class ActorController : ApiController
    {
        private IActorService service;

        public ActorController()
        {
            service = new ActorServiceImp();
        }
        [HttpPost]
        public bool InsertActor(string name, string image, string description, string phone, string email, int insId)
        {
            return service.InsertActor(name, image, description, phone, email, insId);
        }

        [HttpPut]
        public bool UpdatetActor(int id, string name, string image, string description, string phone, string email, int updId)
        {
            return service.UpdateActor(id, name, image, description, phone, email, updId);
        }

        [HttpGet]
        public List<Actor> GetAllActor()
        {
            return service.GetAllActor();
        }
    }
}
