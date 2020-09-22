using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question5.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            
            double fortnight = 5.50;
            int hst = 13;
            int fweek = 14;
            double result1 = 6.22;
            double result2 = 12.43;
            double result3 = 18.64;

            if (fweek = 0)

            {
                Console.WriteLine("Result1");
            }
            
            if (0 < fweek <= 27)
                
                {
                    Console.WriteLine("Result2");
                }
             
            if (fweek >= 28)

                {
                    Console.WriteLine("Result3");
                }
            
        }
    }
}
