using System;
using System.Collections.Generic;
using System.Text;
using BrickProject.DBContext;
using BrickProject.Repository;
using BrickProject.Service;
using Microsoft.EntityFrameworkCore;
using NFluent;
using Xunit;

namespace BrickProjectTests
{
    public class IntegrationTesting
    {
        private readonly IService _service;
        private readonly IRepository _repository;
        private readonly WebAPIDBContext _context;

        public IntegrationTesting()
        {
            var builder = new DbContextOptionsBuilder<WebAPIDBContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebAPIDB;Trusted_Connection=True;");
            _context = new WebAPIDBContext(builder.Options);
            _repository = new Repository(_context);
            _service = new Service(_repository);
        }

        [Fact]
        public void GetCustomer_ReturnsCustomer()
        {
            var result = _service.GetCustomer("abc");

            Check.That(result).IsNotNull();
            Check.That(result.HouseDist).Equals(20);
        }
    }
}
