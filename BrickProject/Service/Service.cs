using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrickProject.DBContext;
using BrickProject.Repository;

namespace BrickProject.Service
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddCustomer(Customer customer)
        {
            return await _repository.AddCustomer(customer);
        }

        public Customer GetCustomer(string id)
        {
            return _repository.GetCustomer( id);
        }
    }
}
