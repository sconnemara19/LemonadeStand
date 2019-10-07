using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        //Member Variables(Has A)

        public Weather weather;
        public List<Customer> customer;

        //Constructor(Spawner)

        public Day()
        {
            weather = new Weather();
            customer = new List<Customer>();
        }
        //create customers
        //sell lemonade
        //going to store
        //

        //Memeber Methods(Can Do)

        public void CreatingCustomer()
        {
            for(int i = 0; i < 7; i++)
            {
                Customer customer = new Customer();
                if (weather.temperature <= 60)
                {
                    
                }

            }
            

        }


        public void SellingLemonade()
        {
            
        }
    }
}
