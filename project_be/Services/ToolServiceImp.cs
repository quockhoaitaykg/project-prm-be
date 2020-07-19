using project_be.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing.Design;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace project_be.Services
{
    public class ToolServiceImp : IToolService
    {
        private projectEntities db;

        public ToolServiceImp()
        {
            this.db = new projectEntities();
        }

        public bool DeleteTool(int id)
        {
            try
            {
                Tool tool = db.Tools.FirstOrDefault(x => x.Id == id);
                if (tool == null)
                {
                    return false;
                }
                tool.DelFlg = true;
                db.Tools.AddOrUpdate(tool);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Tool> GetAllTool()
        {
            return db.Tools.Where(x => x.DelFlg == false).ToList();
        }

        public bool InsertTool(string name, string image, string description, int quantity, bool status)
        {
            try
            {
                Tool tool = new Tool();
                tool.Name = name;
                tool.Image = image;
                tool.Description = description;
                tool.Quantity = quantity;
                tool.Status = status;
                tool.DelFlg = false;
                tool.InsId = 1;
                tool.InsTime = DateTime.Now;
                tool.UpdId = 1;
                tool.UpdTime = DateTime.Now;
                db.Tools.Add(tool);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTool(int id, string name, string image, string description, int quantity, bool status)
        {
            try
            {
                Tool tool = db.Tools.FirstOrDefault(x => x.Id == id);
                if (tool == null)
                {
                    return false;
                }
                if (!name.IsEmpty())
                {
                    tool.Name = name;
                }
                if (!image.IsEmpty())
                {
                    tool.Image = image;
                }
                if (!description.IsEmpty())
                {
                    tool.Description = description;
                }
                if (!quantity.ToString().IsEmpty())
                {
                    tool.Quantity = quantity;
                }
                if (!tool.ToString().IsEmpty())
                {
                    tool.Status = status;
                }
                   
               
                tool.UpdId = 1;
                tool.UpdTime = DateTime.Now;
                db.Tools.AddOrUpdate(tool);
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