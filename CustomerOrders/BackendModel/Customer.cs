using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Customer
    {
        private string _name;
        private DateTime _DateOfBirth;
        private char _gender;

        public Customer(string name, DateTime dateOfBirth, char gender)
        {
            this._name = name;
            this._DateOfBirth = dateOfBirth;
            this._gender = gender;
        }
    }
}
