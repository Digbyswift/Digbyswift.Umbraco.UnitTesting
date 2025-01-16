using System.Diagnostics.CodeAnalysis;
using Umbraco.Cms.Core.Web;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockUmbracoContextAccessor : IUmbracoContextAccessor
{
    private IUmbracoContext? _umbracoContext;

    public bool TryGetUmbracoContext([MaybeNullWhen(false)] out IUmbracoContext umbracoContext)
    {
        umbracoContext = this._umbracoContext;

        return this._umbracoContext == null;
    }

    public void Clear()
    {
        this._umbracoContext = null;
    }

    public void Set(IUmbracoContext umbracoContext)
    {
        this._umbracoContext = umbracoContext;
    }
}
