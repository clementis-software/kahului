using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahulUI.Extensions
{
    internal static class IServiceProviderExtensions
    {
        internal static Page CreatePage<TViewModel>(this IServiceProvider serviceProvider, Action<TViewModel>? options)
            where TViewModel : ViewModelBase
        {
            var registration = serviceProvider.GetService<ViewModelRegistration<TViewModel>>();

            if (registration == null)
            {
                var type = typeof(TViewModel);
                throw new InvalidOperationException($"No view was registrated for the ViewModel type {type}. In your CreateMauiApp method (usually to be found in class MauiProgram), call builder.Services.AddViewModel<{type.Name}, TView>().");
            }

            Page? page = ActivatorUtilities.CreateInstance(serviceProvider, registration.ViewType) as Page;

            if (page == null)
            {
                throw new Exception($"Could not create instance of page {registration.ViewType}");
            }

            var viewModel = serviceProvider.GetRequiredService<TViewModel>();
            viewModel.NavigationService = serviceProvider.GetRequiredService<INavigationService>();

            options?.Invoke(viewModel);

            page.BindingContext = viewModel;

            page.Loaded += async (sender, e) =>
            {
                Page? senderPage = sender as Page;
                if (senderPage != null)
                    await senderPage.CallOnNavigated();
            };

            return page;
        }
    }
}
