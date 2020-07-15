using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace project_be.Services
{
    public class ActorServiceImp :IActorService
    {
        private projectEntities db;

        public ActorServiceImp()
        {
            this.db = new projectEntities();
        }
        [HttpPost]
        public bool InsertActor(string name, string image, string description, string phone, string email, int insId)
        {
            try
            {
                Actor actor = new Actor();
                actor.Name = name;
                actor.Image = image;
                actor.Email = email;
                actor.Description = description;
                actor.Phone = phone;
                actor.InsId = insId;
                actor.DelFlg = false;
                actor.InsTime = DateTime.Now;
                actor.UpdId = insId;
                actor.UpdTime = DateTime.Now;
                db.Actors.Add(actor);
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