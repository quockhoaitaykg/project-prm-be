using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_be.Services
{
    public class MovieActorServiceImp : IMovieActorService
    {
        private projectEntities db;

        public MovieActorServiceImp()
        {
            this.db = new projectEntities();
        }

        public List<CalamityActor> GetAll()
        {
            return db.CalamityActors.ToList();
        }

        public bool InsertActorMovie(int calId, int actorId, string role, string description)
        {
            try
            {
                CalamityActor calamityActor = new CalamityActor();
                calamityActor.CalamityId = calId;
                calamityActor.ActorId = actorId;
                calamityActor.Role = role;
                calamityActor.RoleDescription = description;
                calamityActor.DelFlg = false;
                calamityActor.InsId = 1;
                calamityActor.InsTime = DateTime.Now;
                calamityActor.UpdId = 1;
                calamityActor.UpdTime = DateTime.Now;
                db.CalamityActors.Add(calamityActor);
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