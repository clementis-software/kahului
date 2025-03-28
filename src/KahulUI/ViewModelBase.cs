using CommunityToolkit.Mvvm.ComponentModel;

namespace KahulUI
{
    public class ViewModelBase : ObservableObject
    {
        private INavigationService? _navigationService;

        protected internal INavigationService? NavigationService
        {
            get { return _navigationService; }
            internal set { _navigationService = value; }
        }

        protected internal virtual Task OnNavigated()
        {
            return Task.CompletedTask;
        }
    }
}
