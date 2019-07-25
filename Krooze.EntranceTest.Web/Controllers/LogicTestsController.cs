using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.Tests;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using Krooze.EntranceTest.WriteHere.Tests.LogicTests;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{

    [ApiController]
    public class LogicTestsController : Controller
    {
        [HttpGet]
        [Route("api/LogicTests/GetXML")]
        public ActionResult<CruiseDTO> GetXML()
        {
            return new XMLTest().TranslateXML();
        }

        [Route("api/LogicTests/GetOtherTaxes/{cabinValue}/{portChange}/{totalValue}")]
        [HttpGet]
        public ActionResult<decimal?> GetOtherTaxes(decimal cabinValue, decimal portChange, decimal totalValue)
        {
            return new LogicTests().OtherTaxes(cabinValue, portChange, totalValue);
        }

        [Route("api/LogicTests/IsThereDiscount/{firstPassenger}/{secondPassenger}")]
        [HttpGet]
        public ActionResult<bool?> IsThereDiscount(decimal firstPassenger, decimal secondPassenger)
        {
            return new LogicTests().Discount(firstPassenger, secondPassenger);
        }

        [Route("api/LogicTests/GetInstallments/{fullPrice}")]
        [HttpGet]
        public ActionResult<int?> GetInstallments(decimal fullPrice)
        {
            return new LogicTests().Installments(fullPrice);
        }
    }
}