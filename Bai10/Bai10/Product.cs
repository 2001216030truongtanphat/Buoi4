using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Product : OrderDetail
    {
        private string descripTion;
        public string DeScripTion
        {
            get { return descripTion; }
            set { descripTion = value; }
        }
        private string productID;
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        private double productPrice;
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public Product()
        {
            this.ProductID = string.Empty;
            this.DeScripTion = string.Empty;
            this.ProductPrice = 0;
        }
        public Product(string id, string dpt, double pri)
        {
            this.ProductID = id;
            this.DeScripTion = dpt;
            this.ProductPrice = pri;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
