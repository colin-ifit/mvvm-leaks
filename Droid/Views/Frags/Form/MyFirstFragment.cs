using Android.OS;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;

namespace LeakCanaryTest.Droid.Views
{
    public class MyFirstFragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.Fragment_FirstHeader, null);
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
        }
    }
}