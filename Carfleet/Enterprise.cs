using System;

namespace Carfleet
{
    public class Enterprise
    {
        #region private attributes
        private string name;
        private string street;
        private string city;
        private string phonenumber;
        private string emailaddress;
        #endregion private attributes

        #region public methods
        public Enterprise(string name, string street, string city, string phonenumber, string emailaddress)
        {
            this.name = name;
            this.street = street;
            this.city = city;
            this.phonenumber = phonenumber;
            this.emailaddress = emailaddress;
        }

        public void Add(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void Add(Driver driver)
        {
            throw new NotImplementedException();
        }

        public void AssignVehicleToDriver(string chassiNumber, string driverEmailaddress)
        {
            throw new NotImplementedException();
        }

        public void GetDriverByEmailaddress(string driverEmailaddress)
        {
            throw new NotImplementedException();
        }

        public void UnassignVehicleFromDriver(string chassiNumber)
        {
            throw new NotImplementedException();
        }


        #endregion public methods
    }
}
