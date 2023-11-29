using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Oyuncu Bilgileri Hatalı");

            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
