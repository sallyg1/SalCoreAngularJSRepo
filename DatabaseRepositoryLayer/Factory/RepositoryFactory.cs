using DatabaseRepositoryLayer.context;
using DatabaseRepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseRepositoryLayer.Factory
{
    public interface IRepositoryFactory
    {
        CustomerRepository BuildCustomerRepository();
    }

    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly ApplicationContext _appContext;
        public RepositoryFactory(ApplicationContext  _appContext)
        {
            this._appContext = _appContext;
        }

        public CustomerRepository BuildCustomerRepository()
        {
            return new CustomerRepository(_appContext);
        }
    }
}
