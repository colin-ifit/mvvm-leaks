using System;
using Android.App;
using Android.Widget;
using MvvmCross.Droid.Views;
using LeakCanaryTest.ViewModels;

namespace LeakCanaryTest.Droid.Views
{
    [Activity(Label = "SecondView")]
    public class SecondView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Second);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            // Dispose the activity itself
            Dispose();
        }
    }
}
