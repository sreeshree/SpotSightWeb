using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SpotSightWeb.ViewModel
{
    public class SelectedItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }

        public string UUId { get; set; }

        [Display(Name = "Major Number")]
        public string MajorNumber { get; set; }

        [Display(Name = "Minor Number")]
        public string MinorNumber { get; set; }

        public string Title { get; set; }

        public string ItemDescription { get; set; }

        [Display(Name = "Image Url")]
        public string ItemImageUrl { get; set; }

        [Display(Name = "Video Url")]
        public string VideoUrl { get; set; }

        [Display(Name = "Audio Url")]
        public string AudioUrl { get; set; }
        [Display(Name = "Is Push")]
        public bool IsPush { get; set; }

        public int categoryId { get; set; }
    }
}