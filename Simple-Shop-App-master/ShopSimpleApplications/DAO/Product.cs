using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimpleApplications.DAO
{
    public class Product
    {
        private string product_id;
        private string product_name;
        private double product_quentity;

        public Product(string product_id, string product_name, double product_quentity)
        {
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Product_quentity = product_quentity;
        }

        public string Product_id { get => product_id; set => product_id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public double Product_quentity { get => product_quentity; set => product_quentity = value; }
    }
}
