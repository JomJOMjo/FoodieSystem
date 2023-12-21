using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BusinessLayer
{
    internal class OrderL
    {
        public int id {  get; set; }
        public string Type { get; set; }
        public int cust_id { get; set; }
        public decimal g_Total { get; set; }
        public DateTime trans_date { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
    }
}
