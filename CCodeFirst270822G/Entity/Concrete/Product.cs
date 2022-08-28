using CCodeFirst270822G.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeFirst270822G.Entity.Concrete
{
    public class Product : BaseEntity<int>
    {
        public override int ID { get; set; }
        public override DateTime CreateDate { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }

        //1 ürünün 1 kategorisi olmalı.
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierID { get; set; }
    }
}
