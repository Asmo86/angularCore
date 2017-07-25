using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using angularCore.Models;
using angularCore.Factory;
namespace angularCore.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Person> ListPeople()
        {
            List<Person> returnValue = new List<Person>();
            PersonFactory theFactory = new PersonFactory();
            returnValue = theFactory.create(25);
            return returnValue;
        }
    }
}
