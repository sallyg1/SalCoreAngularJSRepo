using DatabaseRepositoryLayer.Generic;
using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseRepositoryLayer.Repository.Interface
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IList<Customer> GetCustomer();
    }
}
