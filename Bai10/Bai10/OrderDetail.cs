using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class OrderDetail : Order
    {
        
        private int quaTity;
        public int QuaTiTy
        {
            get { return quaTity; }
            set { quaTity = value; }
        }
        private override Product proDuct;
        public double calcTotalPrice()
        {
            double pri = 0;
            do
            {
                pri = quaTity * proDuct.ProductPrice;
                pri += pri;
                count--;
            } while (count == 0);
            return pri;
        }
        public OrderDetail(Product pr, int x)
        {
            this.proDuct = pr;
            this.quaTity = x;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
