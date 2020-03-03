using System;
using Android.App;
using Android.Widget;
using LeakCanaryTest.ViewModels;
using MvvmCross.Droid.Views;
namespace LeakCanaryTest.Droid.Views
{
    [Activity(Label = "DialogFragmentView")]
    public class DialogFragmentView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Second);

            DestroyCalled += (s, e) => {
                if (ViewModel is IDisposable)
                    (ViewModel as IDisposable).Dispose();
            };
        }



        protected override void OnDestroy()
        {
            base.OnDestroy();

            // Dispose the activity itself
            Dispose();
        }
    }
}
