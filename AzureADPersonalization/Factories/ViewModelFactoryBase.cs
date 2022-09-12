using AzureADPersonalization.Models.Pages;
using AzureADPersonalization.Models.ViewModels;

namespace AzureADPersonalization.Factories
{
    public abstract class ViewModelFactoryBase
    {
        public ViewModelFactoryBase()
        {

        }

        public PageViewModel BuildModel(SitePageData currentPage)
        {
            var model = new PageViewModel();
            model.CurrentPage = currentPage;

            return model;
        }
    }
}