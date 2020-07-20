using project_be.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace project_be.Services
{
    public class CalamityServiceImp : ICalamityService
    {
        private projectEntities db;

        public CalamityServiceImp()
        {
            this.db = new projectEntities();
        }

        public bool DeleteCalamity(int id)
        {
            try
            {
                Calamity calamity = db.Calamities.FirstOrDefault(x => x.Id == id);
                if(calamity == null)
                {
                    return false;
                }
                calamity.DelFlg = true;
                db.Calamities.AddOrUpdate(calamity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Calamity> GetAllCalamity()
        {
            return db.Calamities.Where(x => x.DelFlg == false).ToList();
        }

        public Calamity GetCalamityById(int id)
        {
            return db.Calamities.FirstOrDefault(x => x.Id == id);
        }

        public bool InsertCalamity(string name, string description, string location, DateTime dateStart, DateTime dateEnd, int numberOfFilming)
        {
            try
            {
                Calamity calamity = new Calamity();
                calamity.Name = name;
                calamity.Description = description;
                calamity.FilmingLocation = location;
                calamity.TimeStart = dateStart;
                calamity.TimeEnd = dateEnd;
                calamity.NumberOfFilming = numberOfFilming;
                calamity.DelFlg = false;
                calamity.InsId = 1;
                calamity.InsTime = DateTime.Now;
                calamity.UpdId = 1;
                calamity.UpdTime = DateTime.Now;
                db.Calamities.Add(calamity);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCalamity(int id, string name, string description, string location, int numberOfFilming)
        {
            try
            {
                Calamity calamity = db.Calamities.FirstOrDefault(x => x.Id == id);
                CalamityActor calamityActor = db.CalamityActors.FirstOrDefault(x => x.CalamityId == id);
                CalamityTool calamityTool = db.CalamityTools.FirstOrDefault(x => x.CalamityId == id);
                if (calamity == null)
                {
                    return false;
                }
                if (!name.IsEmpty())
                {
                    calamity.Name = name;
                    calamityActor.CalamityDescription = name;
                    calamityTool.CalamityDescription = name;
                }
                if (!description.IsEmpty())
                {
                    calamity.Description = description;
                }
                if (!location.IsEmpty())
                {
                    calamity.FilmingLocation = location;
                }
                
                if (!numberOfFilming.ToString().IsEmpty())
                {
                    calamity.NumberOfFilming = numberOfFilming;
                }
                calamity.UpdTime = DateTime.Now;
                calamity.UpdId = 1;
                db.Calamities.AddOrUpdate(calamity);
                db.CalamityActors.AddOrUpdate(calamityActor);
                db.CalamityTools.AddOrUpdate(calamityTool);
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