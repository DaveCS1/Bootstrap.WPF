using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WPF.Bootstrap.Demo.ViewModels
{
    public class TabInPanelViewModel : ReactiveObject
    {
        public TabInPanelViewModel()
        {
            TabItems = new ReactiveList<TabItemViewModel>();

            TabItems.Add(new TabItemViewModel("test"));
            TabItems.Add(new TabItemViewModel("test 2"));
        }

        public ReactiveList<TabItemViewModel> TabItems { get; set; }
    }
}
