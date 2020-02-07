using System;
using Android.App;
using Android.Widget;
using LeakCanaryTest.ViewModels;
using MvvmCross.Droid.Views;

namespace LeakCanaryTest.Droid.Views
{
    [Activity(Label = "MainView", MainLauncher = true)]
    public class MainView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);       
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            // Dispose the activity itself
            Dispose();
        }
    }
}
