using AzureADPersonalization.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace AzureADPersonalization.Models.Pages
{
    [ContentType(DisplayName = "Home Page", GUID = "775ec2b3-5b3f-4d16-9913-8ccf126c64da")]
    public class HomePage : PageData
    {
        [Display(
            Name = "Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Hero Banner",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual HeroBanner Banner { get; set; }

        [Display(
            Name = "Content",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentArea Content { get; set; }
    }
}