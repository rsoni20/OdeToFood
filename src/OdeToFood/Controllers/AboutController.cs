using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        public string phone()
        {
            return "9924166945";
        }
        [Route("[action]")]
        public string country()
        {
            return "India";
        }
    }
}
