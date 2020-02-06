using System.Windows.Input;
using MvvmCross.Core.ViewModels;
namespace LeakCanaryTest.ViewModels
{
    public class MainViewModel: MvxViewModel
    {
        public override void Start()
        {
            base.Start();
        }

        public ICommand Second
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>()); }
        }
    }
}
