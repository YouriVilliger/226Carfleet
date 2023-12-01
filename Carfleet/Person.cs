﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Carfleet
{
    public class Person
    {
        #region attribut private
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _languages = new List<string>();
        #endregion attribut private

        #region public methods
        public Person(string name, string firstname, string phonenumber, string emailaddress, List<string> languages)
        {
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
            _languages = languages;
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

        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                if (_languages.Count > 0)
                {
                    _languages.AddRange(value);
                }

                foreach (var item in _languages)
                {
                    if (value.Contains(item))
                    {
                        _languages.Remove(item);
                    }
                    return;
                }

                _languages = value;
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
