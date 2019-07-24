using Krooze.EntranceTest.WriteHere.Structure.Model;
using System;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class SimpleLogicTest
    {
        public decimal? GetOtherTaxes(CruiseDTO cruise)
        {
            return cruise.TotalValue - (cruise.CabinValue + cruise.PortCharge);
        }

        public bool? IsThereDiscount(CruiseDTO cruise)
        {
            return cruise.PassengerCruise[1].Cruise.CabinValue < cruise.PassengerCruise[0].Cruise.CabinValue;

        }

        public int? GetInstallments(decimal fullPrice)
        {
            if (fullPrice < 200)
                return 1;
            int i = Convert.ToInt32(fullPrice / 200);
            if (i > 12)
                return 12;
            else
                return i;

        }
    }
}
