using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Web.Common.Routing;

namespace Digbyswift.Umbraco.UnitTesting.Extensions;

public static class ControllerSetupExtensions
{
    public static void SetMockContext<T>(this T controller) where T : Controller
    {
        var mockHttpContext = Substitute.For<HttpContext>();
        mockHttpContext.Features.Returns(new FeatureCollection());

        controller.ControllerContext = new ControllerContext
        {
            HttpContext = mockHttpContext,
        };

        var mockTempDataProvider = Substitute.For<ITempDataProvider>();
        controller.TempData = new TempDataDictionary(controller.HttpContext, mockTempDataProvider);
    }

    public static void SetMockCurrentPage<T>(this Controller controller, IPublishedContent publishedContent)
        where T : PublishedContentModel
    {
        var mockValueFallback = StaticServiceProvider.Instance.GetService<IPublishedValueFallback>();
        var contentModel = Activator.CreateInstance(typeof(T), publishedContent, mockValueFallback) as T;

        var mockPublishedRequest = Substitute.For<IPublishedRequest>();
        mockPublishedRequest.PublishedContent.Returns(contentModel);

        var routeValues = new UmbracoRouteValues(mockPublishedRequest, new ControllerActionDescriptor());

        controller.HttpContext.Features.Set(routeValues);
    }

    public static void SetNullMockCurrentPage(this Controller controller)
    {
        var mockPublishedRequest = Substitute.For<IPublishedRequest>();
        mockPublishedRequest.PublishedContent.Returns((PublishedContentModel?)null);

        var routeValues = new UmbracoRouteValues(mockPublishedRequest, new ControllerActionDescriptor());

        controller.HttpContext.Features.Set(routeValues);
    }
}
