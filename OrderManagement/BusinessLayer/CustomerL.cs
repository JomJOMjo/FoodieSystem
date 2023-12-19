using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BusinessLayer
{
    internal class CustomerL
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string contact {  get; set; }
        public string address { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
