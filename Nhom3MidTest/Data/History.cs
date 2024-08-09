using System;
using System.Collections.Generic;

namespace Nhom3MidTest.Data
{
    public class History
    {
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer BirthDay{ get; set; }
        public Car Make{ get; set; }
        public Car Model { get; set; }

    }
}
