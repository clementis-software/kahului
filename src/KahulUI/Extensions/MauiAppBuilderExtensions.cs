namespace KahulUI.Extensions
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder? UseKahulUI(this MauiAppBuilder? builder, Action<IKahulUIOptions>? config = null)
        {
            if (builder == null)
                return null;

            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IKahulUIWindowProvider, KahulUIWindowProvider>();

            KahulUIOptions options = new KahulUIOptions();

            config?.Invoke(options);

            builder.Services.AddSingleton<IKahulUIOptions>(options);

            return builder;
        }
    }
}
