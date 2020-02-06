using Leakcanary;
using LeakCanaryTest.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Shark;

namespace LeakCanaryTest
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());

			//var config = LeakCanary.Instance.GetConfig();

			//var matchers = config.ReferenceMatchers;
			//matchers.Add(new IgnoredReferenceMatcher(new ReferencePattern.InstanceFieldPattern("android.app.ContextImpl", "mOuterContext")));
			//matchers.Add(new IgnoredReferenceMatcher(new ReferencePattern.InstanceFieldPattern("android.app.ContextImpl", "mAutofillClient")));

			//var copiedConfig = LeakCanary.Instance.GetConfig().Copy(
			//  config.DumpHeap,
			//  config.DumpHeapWhenDebugging,
			//  1,
			//  matchers,
			//  config.ObjectInspectors,
			//  config.OnHeapAnalyzedListener,
			//  config.MetatadaExtractor,
			//  config.ComputeRetainedHeapSize,
			//  config.MaxStoredHeapDumps,
			//  config.RequestWriteExternalStoragePermission,
			//  config.LeakingObjectFinder,
			//  config.UseExperimentalLeakFinders
			//  );

			//LeakCanary.Instance.SetConfig(copiedConfig);
		}
    }
}
