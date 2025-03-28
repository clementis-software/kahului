namespace KahulUI.Extensions
{
    internal static class PageExtensions
    {
        /// <summary>
        /// Either returns the page itself, if it already inherits <see cref="NavigationPage"/>, or wraps it inside a <see cref="NavigationPage"/> and returns the new instance.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static NavigationPage ToNavigationPage(this Page page)
        {
            return page is NavigationPage navigationPage ? navigationPage : new NavigationPage(page);
        }

        public static async Task CallOnNavigated(this Page page)
        {
            if (page.BindingContext is ViewModelBase viewModel)
                await viewModel.OnNavigated();
        }
    }
}
