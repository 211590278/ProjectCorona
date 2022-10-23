using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dbl;
using System.Web.Http.Cors;


namespace Gui.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CoronaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAllMember()
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return Ok(dbl.allMembers());
        }
        [HttpGet]
        public Member GetMemberById(int id)
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return dbl.GetMemberById(id);
        }

        [HttpDelete]
        public String deleteMember(int id)
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return dbl.deleteMember(id);
        }

        [HttpPut]
        public String UpdateMember(Member m)
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return dbl.UpdateMember(m);
        }

        [HttpPost]
        public Member addMember(Member m)
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return dbl.addMember(m);
        }

        public List<coronaDetails> allDetailsCoronaVirus()
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return dbl.allDetailsCoronaVirus();
        }

        [HttpPost]
        public coronaDetails addDetailsCorona(coronaDetails m)
        {
            Dbl.Dbl dbl = new Dbl.Dbl();
            return dbl.addDetailsCorona(m);
        }
    }
}
