﻿using project_be.Models;
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
            return db.Actors.ToList();
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
                if (actor == null)
                {
                    return false;
                }
                if (!name.IsEmpty())
                {
                    actor.Name = name;
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
                actor.UpdId = updId;
                actor.UpdTime = DateTime.Now;
                db.Actors.AddOrUpdate(actor);
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