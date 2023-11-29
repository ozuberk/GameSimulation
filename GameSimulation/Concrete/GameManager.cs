using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine($"{game.GmName} Oyunu Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine($"{game.GmName} Oyunu Silindi");
        }

        public void Sale(Game game, Customer customer, Offer offer)
        {
            Console.WriteLine($"{game.GmName} Oyunu {customer.CstmName} {customer.CstmLastName} İsimli Müşteriye {offer.OfrName} kampanyasıyla yüzde {offer.OfrRate} indirim oranı ile {game.GmPrice - (game.GmPrice * (offer.OfrRate / 100))} Tl'ye Satıldı. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine($"{game.GmName} Oyunu Güncellendi");
        }
    }
}
