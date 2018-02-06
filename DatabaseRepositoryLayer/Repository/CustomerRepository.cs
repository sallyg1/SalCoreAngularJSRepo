using DatabaseRepositoryLayer.context;
using DatabaseRepositoryLayer.Generic;
using DatabaseRepositoryLayer.Repository.Interface;
using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseRepositoryLayer.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationContext _appContext;
        public CustomerRepository(ApplicationContext _appContext): base(_appContext)
        {

        }
       
        public IList<Customer> GetCustomer()
        {
            return GetAll().ToList();
        }
    }
}
