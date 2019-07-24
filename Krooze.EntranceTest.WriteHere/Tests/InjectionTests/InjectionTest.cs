using System.Collections.Generic;
using Krooze.EntranceTest.WriteHere.Structure.Implementations;
using Krooze.EntranceTest.WriteHere.Structure.Model;

namespace Krooze.EntranceTest.WriteHere.Tests.InjectionTests
{
    public class InjectionTest
    {
        public List<CruiseDTO> GetCruises(CruiseRequestDTO request)
        {
            if (request.CruiseCompanyCode == 1)
                return new Company1().GetCruises(request);
            else if (request.CruiseCompanyCode == 2)
                return new Company2().GetCruises(request);
            else if (request.CruiseCompanyCode == 3)
                return new Company3().GetCruises(request);
            else
                throw new System.Exception("Invalid Parameter");

        }
    }
}
