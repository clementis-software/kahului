using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahulUI
{
    public interface IKahulUIOptions
    {
        IKahulUIOptions SetMainViewModel<TViewModel>(Action<TViewModel>? options = null)
            where TViewModel : ViewModelBase;
    }
}
