using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockCompositeViewEngine : ICompositeViewEngine
{
    public IReadOnlyList<IViewEngine> ViewEngines => throw new NotImplementedException();

    public ViewEngineResult FindView(ActionContext context, string viewName, bool isMainPage)
    {
        throw new NotImplementedException();
    }

    public ViewEngineResult GetView(string? executingFilePath, string viewPath, bool isMainPage)
    {
        throw new NotImplementedException();
    }
}
