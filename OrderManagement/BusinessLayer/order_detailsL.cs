using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BusinessLayer
{
    internal class order_detailsL
    {
        public int id {  get; set; }
        public int product_id {  get; set; }
        public decimal rate { get; set; }
        public int qty { get; set; }
        public decimal total { get; set; }
        public int cust_id { get; set; }
        public DateTime added_date {  get; set; }
    }
}
