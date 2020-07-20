using project_be.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace project_be.Services
{
    public class MovieToolServiceImp : IMovieToolService
    {
        private projectEntities db;

        public MovieToolServiceImp()
        {
            this.db = new projectEntities();
        }

        public List<CalamityTool> GetAllTool()
        {
            return db.CalamityTools.ToList();
        }

        public bool InsertMovieTool(int calId, int toolId, int quantity)
        {
            try
            {
                CalamityTool calamityTool = new CalamityTool();
                Calamity calamity = db.Calamities.FirstOrDefault(x => x.Id == calId);
                String calName = calamity.Name;

                Tool tool = db.Tools.FirstOrDefault(x => x.Id == toolId);
                String toolName = tool.Name;
                int toolQuantity = (int)tool.Quantity;
                int afterQuantity = toolQuantity - quantity;
                
                calamityTool.CalamityId = calId;
                calamityTool.ToolId = toolId;
                if (toolQuantity >= quantity)
                {
                    calamityTool.Quantity = quantity;
                }else if (afterQuantity == 0)
                {
                    tool.Status = false;
                }
                else
                {
                    return false;
                }
                calamityTool.ToolDescription = toolName;
                calamityTool.CalamityDescription = calName;
                calamityTool.DelFlg = false;
                calamityTool.InsId = 1;
                calamityTool.InsTime = DateTime.Now;
                calamityTool.UpdId = 1;
                calamityTool.UpdTime = DateTime.Now;

                tool.Quantity = afterQuantity;

                db.CalamityTools.Add(calamityTool);
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