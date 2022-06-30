using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA300622_G2.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _createTime = DateTime.Now;

        public DateTime CreateTime
        {
            get { return _createTime; }  // set'i silme sebebimiz tekrardan set edilemesin.
        }




    }
}
