﻿using System;

namespace Carfleet
{
    public class Driver : Person
    {
        #region private attributes
        private string _workZone;
        private Vehicle _vehicle;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string language = "", string workZone = "") : base(name, firstname, phonenumber, emailaddress, language)
        {
            _workZone = workZone;
        }
        public void TakeAVehicule(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        #endregion public methods
    }
}
