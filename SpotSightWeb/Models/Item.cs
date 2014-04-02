using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpotSightWeb.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "Item Major Minor")]
        public string ItemMajorMinor { get; set; }
        
        public int Title { get; set; }
        
        public int Description { get; set; }
        
        [Display(Name = "Image Url")]
        public int ImageUrl { get; set; }
        
        [Display(Name = "Video Url")]
        public int VideoUrl { get; set; }
        
        [Display(Name = "Is Push")]
        public int IsPush { get; set; }
        
        public Category ItemCatogery { get; set; }

    }
}