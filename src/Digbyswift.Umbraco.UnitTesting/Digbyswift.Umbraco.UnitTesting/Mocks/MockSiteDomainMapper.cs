using System;
using System.Collections.Generic;
using Umbraco.Cms.Core.Routing;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockSiteDomainMapper : ISiteDomainMapper
{
    public DomainAndUri? MapDomain(IReadOnlyCollection<DomainAndUri> domainAndUris, Uri current, string? culture, string? defaultCulture)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DomainAndUri> MapDomains(IReadOnlyCollection<DomainAndUri> domainAndUris, Uri current, bool excludeDefault, string? culture, string? defaultCulture)
    {
        throw new NotImplementedException();
    }
}