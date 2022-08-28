using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeFirst270822G.Entity.Abstract
{
    public abstract class BaseEntity<T>  // T HANGİ CLASS A GİDERSE ONA GÖRE ŞEKİL ALACAK ANLAMINA GELİYOR !!!!
    {
        public abstract T ID { get; set; }
        public virtual DateTime CreateDate { get; set; }
    }
}
