using Microsoft.Extensions.Options;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockOptions<T> : IOptions<T> where T : class
{
    public T Value { get; }

    public MockOptions(T value)
    {
        this.Value = value;
    }
}
