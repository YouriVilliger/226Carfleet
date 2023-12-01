using NUnit.Framework;
using System.Collections.Generic;

namespace Carfleet
{
    public class TestIntegrationDriver
    {
        #region private attributes
        private string _name = "Kiss";
        private string _firstname = "Norbert";
        private string _phonenumber = "+4398567985093";
        private string _emailaddress = "kiss.norbert@fia.com";
        private List<string> _languages = new List<string>();
        private string _workZone = "Spain";
        private Driver _driver;

        string _registration = "VD 123 567";
        string _brand = "Mercedes-Benz";
        string _model = "Vito";
        string _chassisNumber = "SV30-0169266";
        Vehicle _car;
        private Vehicle _vehicle;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _driver = new Driver(_name, _firstname, _phonenumber, _emailaddress, _workZone, _languages);
            _vehicle = new Vehicle(_registration, _brand, _model, _chassisNumber);
        }

        [Test]
        public void TakeAVehicle_NominalCase_VehicleAvailableForTheDriver()
        {
            //given

            //when
            _driver.TakeAVehicle(_vehicle);

            //then
            Assert.AreEqual(_vehicle.Registration, _driver.Vehicle.Registration);
        }
    }
}