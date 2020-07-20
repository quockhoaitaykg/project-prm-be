using project_be.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.WebPages;

namespace project_be.Services
{
    public class ActorServiceImp :IActorService
    {
        private projectEntities db;

        public ActorServiceImp()
        {
            this.db = new projectEntities();
        }


        public List<Actor> GetAllActor()
        {
            return db.Actors.Where(x => x.DelFlg == false).ToList();
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

        public bool UpdateActor(int id, string name, string image, string description, string phone, string email, int updId)
        {
            try
            {
                Actor actor = db.Actors.FirstOrDefault(x => x.Id == id);
                CalamityActor calamityActor = db.CalamityActors.FirstOrDefault(x => x.ActorId == id);
                if (actor == null)
                {
                    return false;
                }
                if (!name.IsEmpty())
                {
                    actor.Name = name;
                    calamityActor.RoleDescription = name;
                } 
                if (!image.IsEmpty())
                {
                    actor.Image = image;
                }
                if (!description.IsEmpty())
                {
                    actor.Description = description;
                }
                if (!phone.IsEmpty())
                {
                    actor.Phone = phone;
                }
                if (!email.IsEmpty())
                {
                    actor.Email = email;
                }
                
                actor.UpdId = updId;
                actor.UpdTime = DateTime.Now;
                db.CalamityActors.AddOrUpdate(calamityActor);
                db.Actors.AddOrUpdate(actor);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteActor(int id)
        {
            Actor actor = db.Actors.FirstOrDefault(x => x.Id == id);
            if(actor == null)
            {
                return false;
            }
            actor.DelFlg = true;
            db.Actors.AddOrUpdate(actor);
            db.SaveChanges();
            return true;
        }
    }
}