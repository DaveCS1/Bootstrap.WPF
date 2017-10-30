using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WPF.Bootstrap.Demo.ViewModels
{
    public class TabItemViewModel : ReactiveObject
    {
        public TabItemViewModel(string header)
        {
            Header = header;
        }

        [Reactive]
        public string Header { get; set; }
    }
}
