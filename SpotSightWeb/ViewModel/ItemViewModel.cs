using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpotSightWeb.ViewModel
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string UUId { get; set; }
        public string MajorNumber { get; set; }
        public string MinorNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public string AudioUrl { get; set; }
        public bool IsPush { get; set; }
        public int categoryId { get; set; }
    }
}