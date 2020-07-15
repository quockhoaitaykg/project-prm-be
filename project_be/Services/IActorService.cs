using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_be.Services
{
    interface IActorService
    {
        bool InsertActor(string name, string image, string description, string phone, string email, int insId);

        bool UpdateActor(int id, string name, string image, string description, string phone, string email, int updId);
    }
}
