using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendModel
{
    public class Customer
    {
        private string _name;
        private DateTime _dateOfBirth;
        private char _gender;
        private ArrayList _orderList;

        public Customer(string name, DateTime dateOfBirth, char gender)
        {
            this._name = name;
            this._dateOfBirth = dateOfBirth;
            this._gender = gender;
            _orderList = new ArrayList();
        }

        public void SetName(string newName)
        {
            this._name = newName;
        }

        public string GetName()
        {
            return this._name;
        }

        public DateTime getDOB()
        {
            return _dateOfBirth;
        }

        public int getCustomerAge()
        {
            return DateTime.Today.Year - getDOB().Year;
        }
    }
}
