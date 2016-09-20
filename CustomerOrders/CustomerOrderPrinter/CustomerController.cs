using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendModel;

namespace CustomerOrderPrinter
{
    class CustomerController
    {
        private CustomerModel CustomerModelObject;
        private CustomerView CustomerViewObject;

        public CustomerController()
        {
            CustomerModelObject = new CustomerModel();
            CustomerViewObject = new CustomerView();
        }

        public void UpdateView()
        {
            CustomerViewObject.PrintAll(CustomerModelObject.ListObject);
        }


    }
}
