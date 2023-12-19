using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.BusinessLayer
{
    internal class CategoryL
    {
        public int id {  get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTime added_date { get; set; }
        public int added_by {  get; set; }
    }
}
