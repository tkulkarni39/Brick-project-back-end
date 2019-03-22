using System;
using System.Collections.Generic;
using System.Text;
using BrickProject.DBContext;
using BrickProject.Repository;
using BrickProject.Service;
using Moq;
using NFluent;
using Xunit;

namespace BrickProjectTests
{
    public class ServiceTesting: BaseTest
    {
        private IService _service;
        private Mock<IRepository> _repositoryMock;
        private IRepository _repository;

        public ServiceTesting()
        {
            _repositoryMock = MockRepository.Create<IRepository>();
            _repository = _repositoryMock.Object;
            _service = new Service(_repository);
        }

        [Fact]
        public void GetCustomer_ReturnsCustomer()
        {
            IList<Customer> customerList = new List<Customer>();
            Customer customer = new Customer() {Id = "abc1", HouseDist = 20 , Floor = 4, Day = true, Coupon = true, Cost = 100};
            customerList.Add(customer);

            _repositoryMock.Setup(x => x.GetCustomer("abc1")).Returns(customer);

            var result = _service.GetCustomer("abc1");

            Check.That(result).IsNotNull();
            Check.That(result.HouseDist).Equals(20);

        }

        //[Fact]
        //public void GetCustomer_ReturnsNull()
        //{
        //    IList<Customer> customerList = null;
        //    //Customer customer = new Customer();
        //    _repositoryMock.Setup(x => x.GetCustomer("abc2")).Returns(customerList);

        //    var result = _service.GetAllCustomers("abc2");
        //    Check.That(result).IsNull();

        //}
    }
}
