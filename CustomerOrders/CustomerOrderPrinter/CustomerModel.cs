using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendModel;

namespace CustomerOrderPrinter
{
    class CustomerModel
    {
        public CustomerList ListObject;

        public CustomerModel()
        {
            ListObject = new CustomerList();
            ListObject.LoadJson();
        }

    }
}
