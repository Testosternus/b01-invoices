﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B01.Invoice.Web.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
