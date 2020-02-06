using MvvmCross.Core.ViewModels;
namespace LeakCanaryTest.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public override void Start()
        {
            base.Start();
        }

        public void GoToMain()
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
