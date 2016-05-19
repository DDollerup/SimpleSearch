using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSearch.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
    }
}