using CCodeFirst270822G.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeFirst270822G.Entity.Concrete
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public override int ID { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string? PicturePath { get; set; }
        public override DateTime CreateDate { get; set; }
        public List<Product> Products { get; set; }
    }
}
