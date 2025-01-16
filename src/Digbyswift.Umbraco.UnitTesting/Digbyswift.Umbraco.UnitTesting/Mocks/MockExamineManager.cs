using System;
using System.Collections.Generic;
using Examine;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockExamineManager : IExamineManager
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool TryGetIndex(string indexName, out IIndex index)
    {
        throw new NotImplementedException();
    }

    public bool TryGetSearcher(string searcherName, out ISearcher searcher)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IIndex>? Indexes { get; set; }
    public IEnumerable<ISearcher>? RegisteredSearchers { get; set; }
}
