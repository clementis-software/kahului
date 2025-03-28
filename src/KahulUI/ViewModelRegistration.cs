namespace KahulUI
{
    internal class ViewModelRegistration<TViewModel>
        where TViewModel : ViewModelBase
    {
        public ViewModelRegistration(Type viewType)
        {
            ViewType = viewType;
        }

        public Type ViewType { get; }
    }
}
