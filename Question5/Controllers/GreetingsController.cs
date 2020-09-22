using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Greetings.Controllers
{
    public class GreetingsController : ApiController
    {
        public string Get(int id)
        {
            Console.WriteLine(Convert.ToString(id));
        }
        public IEnumerable<string> Get()
        {
            string str = $"Greetings + {id} + persons.";
            System.Console.WriteLine(str);
        }

    }

}


