using ParentsDateNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParentsDateNight.Controllers
{
    public class PreferenceController : ApiController
    {
        private ApplicationDbContext context;

        public PreferenceController()
        {
            context = new ApplicationDbContext();
        }
        // GET: api/Preference
        public IEnumerable<Preference> GetPreference()
        {
            return context.Preferences.ToList();
        }

        // GET: api/Preference/5
        public Preference GetPerference(int id)
        {
            var preference = context.Preferences.SingleOrDefault(p => p.Id == id);

            if (preference == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return preference;
        }

        // POST: api/Preference
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Preference/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Preference/5
        public void Delete(int id)
        {
        }
    }
}
