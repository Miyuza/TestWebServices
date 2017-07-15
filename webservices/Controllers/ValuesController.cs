using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webservices.Models;

namespace webservices.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<person> Get()
        {
            return DBHelper.DAL.get();
        }

        // GET api/values/5
        public person Get(int id)
        {
            return DBHelper.DAL.get(id);
        }

        // POST api/values
        public void Post([FromBody]person p)
        {
            DBHelper.DAL.post(p.id,p.name);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]person p)
        {
            DBHelper.DAL.put(id, p.name);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}