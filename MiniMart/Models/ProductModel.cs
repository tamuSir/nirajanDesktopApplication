using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Models
{
    public class ProductModel
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string price { get; set; }
        public int quantity { get; set; }
        public string production_date { get; set; }
        public string expiry_date { get; set; }
        public int intRoleId { get; set; }
        public int categoryId { get; set; }
        public int brandId { get; set; }
        public bool status { get; set; }
        public string roleName { get; set; }
        public string categoryName { get; set; }
        public string brandName { get; set; }
    }
}
