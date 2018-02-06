using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interface
{
    public interface ICustomerService
    {
        IList<Customer> GetCustomer();
    }
}
