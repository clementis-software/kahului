namespace KahulUI
{
    public interface INavigationService
    {
        Task Navigate<TViewModel>(Action<TViewModel>? options = null)
            where TViewModel : ViewModelBase;
    }
}
