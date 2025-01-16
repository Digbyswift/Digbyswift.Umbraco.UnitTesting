using Umbraco.Cms.Core.Models.PublishedContent;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockVariationContextAccessor : IVariationContextAccessor
{
    public VariationContext? VariationContext { get; set; }
}
