using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    public class Offer : IEntities
    {
        public int OfrId { get; set; }
        public string OfrName { get; set; }
        public float OfrRate { get; set; }
    }
}
