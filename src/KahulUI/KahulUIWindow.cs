using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahulUI
{
    internal class KahulUIWindow : Window
    {
        public KahulUIWindow(Page page)
            : base(page)
        { }

        //protected override async void OnActivated()
        //{
        //    if (Page?.BindingContext is ViewModelBase viewModelBase)
        //        await viewModelBase.OnNavigated();
        //    base.OnActivated();
        //}
    }
}
