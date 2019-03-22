using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BrickProject.DBContext;
using BrickProject.Service;

namespace BrickProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrickController : ControllerBase
    {
        private readonly IService _service;

        public BrickController(IService service)
        {
            _service = service;
        }

        [Route("getCustomer")]
        [HttpGet]
        public Customer GetCustomer(string id)
        {
            return _service.GetCustomer(id);
        }

        [Route("addCustomer")]
        [HttpPost]
        public async Task<bool> AddCustomer(Customer customer)
        {
            return await _service.AddCustomer(customer);
        }

    }

}