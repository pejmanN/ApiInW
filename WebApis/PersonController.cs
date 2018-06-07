using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebApis.Models;

namespace WebApis
{
    public class PersonController : ApiController
    {
        public IEnumerable<Person> Get()
        {
            var personList = new List<Person>
            {
                new Person { Id = 1, Name = "Pejman" },
                new Person { Id = 2, Name = "Reza" },
                new Person { Id = 3, Name = "Moosa" }
            };
            return personList.ToArray();
        }
    }
}
