using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using LeakCanaryTest.ViewModels.Dialog;
using LeakCanaryTest.ViewModels.Form;
using LeakCanaryTest.ViewModels.Shakespeare;
using LeakCanaryTest.ViewModels.Tab;

namespace LeakCanaryTest.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private NamesViewModel _names = new NamesViewModel();

        public NamesViewModel Names
        {
            get { return _names; }
            set
            {
                _names = value;
                RaisePropertyChanged(() => Names);
            }
        }

        public ICommand ShowFormCommand
        {
            get { return new MvxCommand(() => ShowViewModel<SearchViewModel>()); }
        }

        public ICommand ShowTabsCommand
        {
            get { return new MvxCommand(() => ShowViewModel<TabViewModel>()); }
        }

        public ICommand ShowShakespeareCommand
        {
            get { return new MvxCommand(() => ShowViewModel<TitlesViewModel>());}
        }
    }
}