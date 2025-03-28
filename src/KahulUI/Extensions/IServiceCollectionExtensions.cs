using System.Diagnostics.CodeAnalysis;

namespace KahulUI.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSingletonViewModel<
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TView,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TViewModel>
            (this IServiceCollection services)
            where TView : VisualElement
            where TViewModel : ViewModelBase
        {
            services.AddSingleton(new ViewModelRegistration<TViewModel>(typeof(TView)));
            services.AddSingleton<TViewModel>();

            return services;
        }

        public static IServiceCollection AddTransientViewModel<
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TView,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TViewModel>
            (this IServiceCollection services)
            where TView : VisualElement
            where TViewModel : ViewModelBase
        {
            services.AddSingleton(new ViewModelRegistration<TViewModel>(typeof(TView)));
            services.AddTransient<TViewModel>();

            return services;
        }

        public static IServiceCollection AddScopedViewModel<
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TView,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TViewModel>
            (this IServiceCollection services)
            where TView : VisualElement
            where TViewModel : ViewModelBase
        {
            services.AddSingleton(new ViewModelRegistration<TViewModel>(typeof(TView)));
            services.AddScoped<TViewModel>();

            return services;
        }
    }
}
