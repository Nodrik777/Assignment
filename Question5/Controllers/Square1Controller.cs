using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class Square1Controller : ApiController
    {
        public int Get(int id)
        {
            return id*id;
        }
    }
}
