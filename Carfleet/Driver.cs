using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Driver : Person
    {
        #region private attributes
        private string _workZone;
        private Vehicle _vehicle;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone = null, List<string> languages = null) : base(name, firstname, phonenumber, emailaddress, languages)
        {
            _workZone = workZone;
        }
        public void TakeAVehicule(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string WorkZone
        {
            get
            {
                return _workZone;
            }
        }

        public Vehicle Vehicle
        {
            get
            {
                return _vehicle;
            }
        }

        public void TakeAVehicle(Vehicle vehicle)
        {
            if (_vehicle != null)
            {
                throw new VehicleAlreadyAssignedException();
            }
            _vehicle = vehicle;
        }

        public void ReleaseAVehicle()
        {
            if (_vehicle != null)
            {
                throw new NoVehicleAssignedException();
            }
            _vehicle = null;
        }

        #endregion public methods
    }

    public class NoVehicleAssignedException : Exception { }
    public class VehicleAlreadyAssignedException : Exception { }
}
