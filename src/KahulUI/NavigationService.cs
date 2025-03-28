using KahulUI.Extensions;

namespace KahulUI
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Navigate<TViewModel>(Action<TViewModel>? options = null)
            where TViewModel : ViewModelBase
        {
            Page page = _serviceProvider.CreatePage<TViewModel>(options);
            await GetNavigation()!.PushAsync(page);
        }

        public async Task NavigateBack()
        {
            await GetNavigation()!.PopAsync();
        }

        private INavigation? GetNavigation()
        {
            return Application.Current?.Windows[0].Navigation;
        }
    }
}
