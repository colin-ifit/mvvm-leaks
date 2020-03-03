using System;
using System.Collections.Generic;

namespace LeakCanaryTest.Services.Search
{
    public interface ISearchService
    {
        void GetItems(string key, Action<List<SearchResult>> onSuccess, Action<SearchServiceError> onError);
    }
}