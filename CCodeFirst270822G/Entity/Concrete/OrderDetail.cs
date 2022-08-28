using CCodeFirst270822G.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeFirst270822G.Entity.Concrete
{
    public class OrderDetail : BaseEntity<int>
    {
        public override int ID { get; set; }
        public override DateTime CreateDate { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public Product Products { get; set; }
        public int ProductID { get; set; }
        public Order Orders { get; set; }
        public int OrderID { get; set; }
    }
}
