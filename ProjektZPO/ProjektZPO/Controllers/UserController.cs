using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjektZPO.Models;

namespace ProjektZPO.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<User> Get()
        {
            return new[] { new Pupil(0, 930101011.ToString(), "Radek", "Smialek", "qwe@qwe.com", AccountState.Active ), new Pupil(1, 930101011.ToString(), "Lukasz", "Pukacz", "asd@asd.com", AccountState.Active ) };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            UserPersistance up = new UserPersistance();

            return up.test;
        }

        // POST: api/User
        public void Post([FromBody]User value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
