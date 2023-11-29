using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
