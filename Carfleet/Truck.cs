using System;

namespace Carfleet{
    public class Truck:Vehicle
    {
        #region private attributes
        private Boolean _isCarryingGoods = false;
        #endregion private attributes

        #region public methods
        public Truck(string registration, string brand, string model, string chassisNumber):base(registration, brand, model, chassisNumber)
        {
        }

        public Boolean IsCarryingGoods
        {
            get
            {
                return _isCarryingGoods;
            }
            set
            {
                _isCarryingGoods = value;
            }
        }

        public override string ToString()
        {
            string message = base.ToString();
            if (!IsCarryingGoods)
            {
                message += " - " + IsCarryingGoods.ToString().ToLower();
            }
            return message;
        }
        #endregion public methods
    }
}
