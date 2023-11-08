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
        #endregion public methods
    }
}
