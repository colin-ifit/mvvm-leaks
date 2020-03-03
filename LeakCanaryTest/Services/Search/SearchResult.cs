using System;

namespace LeakCanaryTest.Services.Search
{
    public class SearchResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public DateTime When { get; set; }
    }
}