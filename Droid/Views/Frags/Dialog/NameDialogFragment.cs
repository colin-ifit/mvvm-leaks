using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using LeakCanaryTest.ViewModels;
using LeakCanaryTest.ViewModels.Dialog;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using System;

namespace LeakCanaryTest.Droid.Views
{
    public class NameDialogFragment : MvxDialogFragment
    {
        View view;
        AlertDialog.Builder dialog;

        public NamesViewModel NamesViewModel
        {
            get { return (NamesViewModel) ViewModel; }
        }

        public override Dialog OnCreateDialog(Bundle savedState)
        {
            base.EnsureBindingContextSet(savedState);

            view = this.BindingInflate(Resource.Layout.Dialog_Names, null);
            //editTextTest = view.FindViewById<EditText>(Resource.Id.FirstNameEditText);

            dialog = new AlertDialog.Builder(Activity);
            dialog.SetTitle("Name Dialog");
            dialog.SetView(view);
            dialog.SetNegativeButton("Cancel", (s, a) => { });
            dialog.SetPositiveButton("OK", (s, a) => 
                    Toast.MakeText(Activity.ApplicationContext, string.Format("Full name is: {0}", NamesViewModel.FullName), ToastLength.Short).Show()
                );
            return dialog.Create();
        }

        public override void OnDestroyView()
        {
            
            view.Dispose();
            dialog.Dispose();
            //editTextTest.Dispose();
            ////view = null;
            ////dialog = null;

            //GC.Collect();
            //Java.Lang.JavaSystem.Gc();
            base.OnDestroyView();

        }

        public override void OnDestroy()
        {
            base.OnDestroy();

        }
    }
}