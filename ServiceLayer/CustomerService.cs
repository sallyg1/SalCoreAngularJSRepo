using DatabaseRepositoryLayer.context;
using DatabaseRepositoryLayer.Factory;
using DatabaseRepositoryLayer.Generic;
using DatabaseRepositoryLayer.Repository.Interface;
using DomainLayer.Model;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryFactory _repoFact;
        private readonly ICustomerRepository _custRepo;

        //private readonly ApplicationContext _appContext;
        public CustomerService(IRepositoryFactory _repoFact)
        {

            //this._appContext = _appContext;
            this._repoFact = _repoFact;
           this._custRepo = _repoFact.BuildCustomerRepository();
        }
        public IList<Customer> GetCustomer()
        {
            return _custRepo.GetCustomer();
        }
    }
}
