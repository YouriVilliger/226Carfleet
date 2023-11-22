using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfleet
{
    public class Person
    {
        #region attribut private
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailAddress;
        private string _language;
        #endregion attribut private

        #region method public
        public Person(string name,string firstname, string phonenumber, string emailAddress, string language = "") {
        
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailAddress = emailAddress;
            _language = language;
        }

        #endregion method public
    }
}
