using KahulUI.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahulUI
{
    internal class KahulUIOptions : IKahulUIOptions
    {
        internal Func<IServiceProvider, Page>? MainPageCreatorFunc {  get; private set; }

        public IKahulUIOptions SetMainViewModel<TViewModel>(Action<TViewModel>? options = null) where TViewModel : ViewModelBase
        {
            MainPageCreatorFunc = serviceProvider => serviceProvider.CreatePage<TViewModel>(options);
            return this;
        }
    }
}
