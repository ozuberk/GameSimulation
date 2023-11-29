using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    public interface IGameService
    {
        void Sale(Game game,Customer customer,Offer offer);
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
