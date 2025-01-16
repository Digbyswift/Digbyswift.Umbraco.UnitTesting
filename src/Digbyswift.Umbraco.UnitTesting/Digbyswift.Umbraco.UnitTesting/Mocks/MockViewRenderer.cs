using System;
using System.Threading.Tasks;
using Digbyswift.Umbraco.Web.Controllers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockViewRenderer : IViewRenderer
{
    public Task<string> RenderAsStringAsync<TModel>(Controller controller, string name, TModel model)
    {
        throw new NotImplementedException();
    }

    public Task<string> RenderAsStringAsync<TModel>(ViewComponent component, string name, TModel model)
    {
        throw new NotImplementedException();
    }

    public Task<HtmlString> RenderAsHtmlStringAsync<TModel>(Controller controller, string name, TModel model)
    {
        throw new NotImplementedException();
    }

    public Task<HtmlString> RenderAsHtmlStringAsync<TModel>(ViewComponent component, string name, TModel model)
    {
        throw new NotImplementedException();
    }
}
