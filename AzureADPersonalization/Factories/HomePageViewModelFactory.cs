using AzureADPersonalization.Models.Pages;
using AzureADPersonalization.Models.ViewModels;

namespace AzureADPersonalization.Factories
{
    public class HomePageViewModelFactory : ViewModelFactoryBase
    {
        public HomePageViewModelFactory()
        {

        }

        public HomePageViewModel BuildModel(HomePage currentPage)
        {
            var model = base.BuildModel(currentPage) as HomePageViewModel;

            return model;
        }
    }
}