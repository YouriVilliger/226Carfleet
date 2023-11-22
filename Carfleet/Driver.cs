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
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> languages) : base(name, firstname, phonenumber, emailaddress, languages)
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

        #endregion public methods
    }
}
