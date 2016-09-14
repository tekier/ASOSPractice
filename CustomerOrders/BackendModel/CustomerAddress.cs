using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BackendModel
{
    public class CustomerAddress
    {
        private string _house;
        private string _postcode;

        public CustomerAddress(string house, string postcode)
        {
            this._house = house;
            this._postcode = postcode;
        }


        public void SetHouse(string houseName)
        {
            this._house = houseName;
        }

        public string GetHouse()
        {
            return this._house;
        }

        public void SetPostcode(string postcode)
        {
            this._postcode = postcode;
        }

        public string GetPostcode()
        {
            return this._postcode;
        }
    }
}
