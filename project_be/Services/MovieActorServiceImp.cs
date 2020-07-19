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

        public bool InsertActorMovie(int calId, int actorId, string role)
        {
            try
            {
                CalamityActor calamityActor = new CalamityActor();
                Actor actor = db.Actors.FirstOrDefault(x => x.Id == actorId);
                String actorName = actor.Name;
                Calamity calamity = db.Calamities.FirstOrDefault(x => x.Id == calId);
                String calName = calamity.Name;


                calamityActor.CalamityId = calId;
                calamityActor.ActorId = actorId;
                calamityActor.Role = role;
                calamityActor.RoleDescription = actorName;
                calamityActor.CalamityDescription = calName;
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