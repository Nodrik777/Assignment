using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Greeting.Controllers
{
    public class GreetingController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {"Hello World!" };
        }
              
    }
}
