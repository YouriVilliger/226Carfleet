using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Threading;

namespace Carfleet
{
    public class Person
    {
        #region attribut private
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _language;
        #endregion attribut private

        #region public methods
        public Person(string name, string firstname, string phonenumber, string emailaddress, List<string> language = null)
        {
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
            _language = language;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public string Firstname
        {
            get
            {
                return _firstname;
            }
        }

        public string Phonenumber
        {
            get
            {
                return _phonenumber;
            }
        }

        public List<string> Language
        {
            get
            {
                return _language;
            }
        }

        public string Emailaddress
        {
            get
            {
                return _emailaddress;
            }
        }
        #endregion public methods
    }
}
