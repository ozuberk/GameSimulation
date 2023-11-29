using GameSimulation.Abstract;
using GameSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace GameSimulation.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            try
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

                var result = client.TCKimlikNoDogrulaAsync(
                    Convert.ToInt64(customer.NationalityId),
                    customer.CstmName.ToUpper(),
                    customer.CstmLastName.ToUpper(),
                    customer.DateOfBirth.Year).Result;

                var body = result.Body;

                return body.TCKimlikNoDogrulaResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata Oluştu :"+ex.Message);
                return false;
            }
        }
    }
}
