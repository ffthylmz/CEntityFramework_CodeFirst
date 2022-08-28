using CCodeFirst270822G.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeFirst270822G.Entity.Concrete
{
    public class Region : BaseEntity<int>
    {
        public override int ID { get; set; } //base entity den kalıtım aldığımız için buna gerek kalmadı...!

        public string RegionDescription { get; set; }
        public override DateTime CreateDate { get; set; }
    }
}
