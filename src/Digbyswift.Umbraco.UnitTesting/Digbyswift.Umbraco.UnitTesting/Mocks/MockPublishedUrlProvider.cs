using System;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockPublishedUrlProvider : IPublishedUrlProvider
{
    public string GetUrl(Guid id, UrlMode mode = UrlMode.Default, string? culture = null, Uri? current = null)
    {
        throw new NotImplementedException();
    }

    public string GetUrl(int id, UrlMode mode = UrlMode.Default, string? culture = null, Uri? current = null)
    {
        throw new NotImplementedException();
    }

    public string GetUrl(IPublishedContent content, UrlMode mode = UrlMode.Default, string? culture = null, Uri? current = null)
    {
        throw new NotImplementedException();
    }

    public string GetUrlFromRoute(int id, string? route, string? culture)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<UrlInfo> GetOtherUrls(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<UrlInfo> GetOtherUrls(int id, Uri current)
    {
        throw new NotImplementedException();
    }

    public string GetMediaUrl(Guid id, UrlMode mode = UrlMode.Default, string? culture = null, string propertyAlias = "umbracoFile", Uri? current = null)
    {
        throw new NotImplementedException();
    }

    public string GetMediaUrl(IPublishedContent? content, UrlMode mode = UrlMode.Default, string? culture = null, string propertyAlias = "umbracoFile", Uri? current = null)
    {
        throw new NotImplementedException();
    }

    public UrlMode Mode { get; set; }
}