using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    [ApiController]
    public class InjectionTestsController : Controller
    {
        // GET api/InjectionTests
        [Route("api/InjectionTests/GetCruises/{companyCode}")]
        [HttpGet]
        public ActionResult<List<CruiseDTO>> GetCruises(int companyCode)
        {
            CruiseRequestDTO cruise = new CruiseRequestDTO();
            cruise.CruiseCompanyCode = companyCode;
            return new InjectionTest().GetCruises(cruise);
        }
    }
}