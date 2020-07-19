using project_be.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_be.Services
{
    interface IMovieActorService
    {
        bool InsertActorMovie(int calId, int actorId, string role, string description);
        List<CalamityActor> GetAll();
    }
}
