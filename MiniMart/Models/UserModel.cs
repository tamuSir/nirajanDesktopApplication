using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Models
{
    public class UserModel
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string roleName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int roleId { get; set; }
        public string password { get; set; } // for list view
        public string hasPassword { get; set; } // for insert
        public string dtFromDate { get; set; }
        public string dtToDate { get; set; }
        public string designation { get; set; }
        public bool status { get; set; }
    }
}
