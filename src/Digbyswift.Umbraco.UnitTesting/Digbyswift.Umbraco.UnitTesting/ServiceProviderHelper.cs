using System;
using Digbyswift.Umbraco.UnitTesting.Mocks;
using Examine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NSubstitute;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;

namespace Digbyswift.Umbraco.UnitTesting;

public static class ServiceProviderHelper
{
    public static void SetUp()
    {
        var serviceProvider = Substitute.For<IServiceProvider>();
        var fallback = Substitute.For<IPublishedValueFallback>();

        var variationContextAccessor = new MockVariationContextAccessor();
        var publishedModelFactory = new MockPublishedModelFactory();
        var publishedUrlProvider = new MockPublishedUrlProvider();
        var userService = new MockUserService();
        var contextAccessor = new MockUmbracoContextAccessor();
        var siteDomainMapper = new MockSiteDomainMapper();
        var examineManager = new MockExamineManager();
        var fileService = new MockFileService();
        var webRoutingOptions = new MockOptions<WebRoutingSettings>(new WebRoutingSettings());
        var contentTypeService = new MockContentTypeService();
        var mediaTypeService = new MockMediaTypeService();
        var memberTypeService = new MockMemberTypeService();

#pragma warning disable NS1000
        serviceProvider.GetService<IPublishedValueFallback>().Returns(fallback);
        serviceProvider.GetService<IVariationContextAccessor>().Returns(variationContextAccessor);
        serviceProvider.GetService<IPublishedModelFactory>().Returns(publishedModelFactory);
        serviceProvider.GetService<IPublishedUrlProvider>().Returns(publishedUrlProvider);
        serviceProvider.GetService<IUserService>().Returns(userService);
        serviceProvider.GetService<IUmbracoContextAccessor>().Returns(contextAccessor);
        serviceProvider.GetService<ISiteDomainMapper>().Returns(siteDomainMapper);
        serviceProvider.GetService<IExamineManager>().Returns(examineManager);
        serviceProvider.GetService<IFileService>().Returns(fileService);
        serviceProvider.GetService<IOptions<WebRoutingSettings>>().Returns(webRoutingOptions);
        serviceProvider.GetService<IContentTypeService>().Returns(contentTypeService);
        serviceProvider.GetService<IMediaTypeService>().Returns(mediaTypeService);
        serviceProvider.GetService<IMemberTypeService>().Returns(memberTypeService);

        StaticServiceProvider.Instance = serviceProvider;
    }
}
