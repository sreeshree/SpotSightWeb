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

        public string UUId { get; set; }

        [Display(Name = "Major Number")]
        public string MajorNumber { get; set; }

        [Display(Name = "Minor Number")]
        public string MinorNumber { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Video Url")]
        public string VideoUrl { get; set; }

        [Display(Name = "Audio Url")]
        public string AudioUrl { get; set; }
        [Display(Name = "Is Push")]
        public bool IsPush { get; set; }
        
        public Category ItemCatogery { get; set; }

    }
}