using System;

namespace LeakCanaryTest.ViewModels.Tab
{
    public class FirstTabViewModel : BaseSubTabViewModel
    {
        public FirstTabViewModel()
        {
            Hello = "Hello World from MvvmCross Fragments";
            When = DateTime.UtcNow;
        }

        public string Hello { get; set; }
        public DateTime When { get; set; }
    }
}