using GameSimulation.Adapters;
using GameSimulation.Concrete;
using GameSimulation.Entities;

namespace GameSimulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { GmId=1,GmName="Call Of Duty",GmPrice=2000,ReleaseDate=new DateTime(2023,11,29)};
            Customer customer1 = new Customer() {CstmName="İzettin",CstmLastName="Özüberk",DateOfBirth=new DateTime(1995,01,28),NationalityId="8971656485"};
            Offer offer1 = new Offer() {OfrId=1,OfrName="Yeni Üyelik",OfrRate=40};
            

            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer1);

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Add(customer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Sale(game1, customer1, offer1);
        }
    }
}