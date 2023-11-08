namespace Carfleet
{
    public class Driver
    {
        #region private attributes
        private string name;
        private string firstname;
        private string city;
        private string phonenumber;
        private string emailaddress;
        private string language;
        private string workZone;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string language = "", string workZone = "")
        {
            this.name = name;
            this.firstname = firstname;
            this.city = firstname;
            this.phonenumber = phonenumber;
            this.emailaddress = emailaddress;
            this.language = language;
            this.workZone = workZone;
        }
        #endregion public methods
    }
}
