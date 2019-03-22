using System;
using System.Collections.Generic;

namespace BrickProject.DBContext
{
    public partial class Customer
    {
        public string Id { get; set; }
        public int? HouseDist { get; set; }
        public int? Floor { get; set; }
        public bool? Day { get; set; }
        public bool? Coupon { get; set; }
        public  int? Cost { get; set; }
    }
}
