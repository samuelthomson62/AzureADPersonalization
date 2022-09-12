using EPiServer.Core;
using AzureADPersonalization.Models.Blocks;

namespace AzureADPersonalization.Models.ViewModels
{
    public class HomePageViewModel : PageViewModel
    {
        public string Title { get; set; }

        public HeroBannerBlock HeroBanner { get; set; }

        public ContentArea Content { get; set; }
    }
}