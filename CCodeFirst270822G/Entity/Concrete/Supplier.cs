﻿using CCodeFirst270822G.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeFirst270822G.Entity.Concrete
{
    public class Supplier : BaseEntity<int>
    {
        public override DateTime CreateDate { get; set; }
        public override int ID { get; set; }
        //public override int ID { get; set; }
        public string CompanyName { get; set; }

        [Required]
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
