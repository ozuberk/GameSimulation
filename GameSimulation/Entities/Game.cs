using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    public class Game : IEntities
    {
        public int GmId { get; set; }
        public string GmName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GmPrice { get; set; }
    }
}
