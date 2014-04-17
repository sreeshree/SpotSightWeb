using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotSightWeb.Models
{
    public class Category
    {

        public Category()
        {
            Items = new List<Item>();
        }
        public int Id { get; set; }

        //public int UUId { get; set; } This will be the Becon unique id.

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
    }
}