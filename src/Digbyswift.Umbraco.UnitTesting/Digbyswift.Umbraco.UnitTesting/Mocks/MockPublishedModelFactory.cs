using System;
using System.Collections;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockPublishedModelFactory : IPublishedModelFactory
{
    public IPublishedElement CreateModel(IPublishedElement element)
    {
        throw new NotImplementedException();
    }

    public IList? CreateModelList(string? alias)
    {
        throw new NotImplementedException();
    }

    public Type GetModelType(string? alias)
    {
        throw new NotImplementedException();
    }

    public Type MapModelType(Type type)
    {
        throw new NotImplementedException();
    }
}
