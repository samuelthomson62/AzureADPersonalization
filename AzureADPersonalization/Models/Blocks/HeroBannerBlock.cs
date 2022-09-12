using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace AzureADPersonalization.Models.Blocks
{
    [ContentType(DisplayName = "HeroBanner", GUID = "86bc1892-1a81-476f-87ee-12d1c1dd3e85", Description = "")]
    public class HeroBannerBlock : BlockData
    {
        [Display(
            Name = "Description",
            Description = "Text displayed in the hero banner",
            Order = 1)]
        public virtual string Description { get; set; }

        [Display(
            Name = "Banner Image",
            Description = "Image displayed in the banner",
            Order = 2)]
        public virtual ContentReference BannerImage { get; set; }
    }
}