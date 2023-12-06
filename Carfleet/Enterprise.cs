using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
        private List<Vehicle> vehicles = new List<Vehicle>();
        private List<Driver> drivers = new List<Driver>();
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
            vehicles.Add(vehicle);
        }

        public void Add(Driver driver)
        {
            drivers.Add(driver);
        }

        public void AssignVehicleToDriver(string chassiNumber, string driverEmailaddress)
        {
            Driver driver = GetDriverByEmailaddress(driverEmailaddress);
            Vehicle vehicle = GetVehicleByChassisNumber(chassiNumber);
            driver.TakeAVehicule(vehicle);
        }

        public Driver GetDriverByEmailaddress(string driverEmailaddress)
        {
            foreach (Driver driver in drivers)
            {
                if (driver.Emailaddress == driverEmailaddress)
                {
                    return driver;
                }
            }
            return null;
        }

        public void UnassignVehicleFromDriver(string chassiNumber)
        {
            throw new NotImplementedException();
        }
        
        public Vehicle GetVehicleByChassisNumber(string chassiNumber)
        {
            foreach (Vehicle vehicle in vehicles)
            {
             if(vehicle.ChassisNumber == chassiNumber)
                {
                    return vehicle;
                }
            }
            return null;
        }

        #endregion public methods
    }
}
