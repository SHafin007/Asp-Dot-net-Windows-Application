using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSimpleApplications.DAO
{
    public class Shop
    {
        private string shope_name;
        private string shope_address;

        List<Product> products = new List<Product>();

        public Shop(string shope_name, string shope_address)
        {
            this.Shope_name = shope_name;
            this.Shope_address = shope_address;
        }

        public string Shope_name { get => shope_name; set => shope_name = value; }
        public string Shope_address { get => shope_address; set => shope_address = value; }
        public List<Product> Products { get => products; set => products = value; }

        public string Add(Product aproduct)
        {
            if(!DoesExist(aproduct.Product_id))
            {
                Products.Add(aproduct);
                return "Product has been added";
            }
            else
            {
                return "You have already added this product";
            }
            
        }

        private bool DoesExist(string product_id)
        {
            foreach(Product aproduct in products)
            {
                if (aproduct.Product_id == product_id)
                {
                    return true;
                }
                
            }
            return false;
            
        }
    }
}
