using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrickProject.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BrickProject.Repository
{
    public class Repository : IRepository
    {
        private readonly WebAPIDBContext _context;

        public Repository(WebAPIDBContext context)
        {
            _context = context;
        }
        public async Task<bool> AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);

            var result = await _context.SaveChangesAsync();

            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Customer GetCustomer(string id)
        {
            return _context.Customer.ToList().Where((item => item.Id == id)).FirstOrDefault();
        }
    }
}
