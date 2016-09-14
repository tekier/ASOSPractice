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
        private ArrayList _orderList = new ArrayList();

        public Customer(string name, DateTime dateOfBirth, char gender)
        {
            this._name = name;
            this._dateOfBirth = dateOfBirth;
            this._gender = gender;
        }

        public void SetName(string newName)
        {
            this._name = newName;
        }

        public string GetName()
        {
            return this._name;
        }

        public DateTime GetDOB()
        {
            return _dateOfBirth;
        }

        public int GetCustomerAge()
        {
            return DateTime.Today.Year - GetDOB().Year;
        }

        public void AddOrder(Order newOrder)
        {
            _orderList.Add(newOrder);
        }

        public Order GetOrder(int orderIndex)
        {
            return (Order)_orderList[orderIndex];
        }

        public int GetNumberOfOrders()
        {
            return _orderList.Count;
        }
    }
}
