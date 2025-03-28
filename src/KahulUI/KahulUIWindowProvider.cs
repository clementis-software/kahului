using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahulUI
{
    internal class KahulUIWindowProvider : IKahulUIWindowProvider
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IKahulUIOptions _options;

        public KahulUIWindowProvider(IServiceProvider serviceProvider, IKahulUIOptions options)
        {
            _serviceProvider = serviceProvider;
            _options = options;
        }

        public Window CreateWindow()
        {
            if (_options is KahulUIOptions options)
                return new KahulUIWindow(options.MainPageCreatorFunc(_serviceProvider));
            return new Window();
        }
    }
}
