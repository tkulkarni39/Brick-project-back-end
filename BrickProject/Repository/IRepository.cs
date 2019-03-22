using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrickProject.DBContext;

namespace BrickProject.Repository
{
    public interface IRepository
    {
        Customer GetCustomer(string id);
        Task<bool> AddCustomer(Customer customer);
    }
}
