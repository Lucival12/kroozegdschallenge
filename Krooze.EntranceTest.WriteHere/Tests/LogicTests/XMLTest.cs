using Krooze.EntranceTest.WriteHere.Structure.Model;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class XMLTest
    {
        public CruiseDTO TranslateXML()
        {
            XmlSerializer serializer2 = new XmlSerializer(typeof(CruiseDTO));
            CruiseDTO cruises = (CruiseDTO)serializer2.Deserialize(new XmlTextReader("C:/Users/admin/source/repos/Lucival12/kroozegdschallenge/Krooze.EntranceTest.WriteHere/Resources/Cruises.xml"));

            return cruises;
        }
    }
}
