using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BusinessLayer
{
    internal class UserBL
    {
        public int userId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set;}
        public string Email { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string User_Type { get; set; }
        public DateTime added_date {  get; set; }
    

    }
}
