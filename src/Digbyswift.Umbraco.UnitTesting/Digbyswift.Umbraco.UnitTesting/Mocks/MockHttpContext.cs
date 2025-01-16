using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using NSubstitute;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockHttpContext : HttpContext
{
    public MockHttpContext()
    {
        this.WebSockets = Substitute.For<WebSocketManager>();
        this.Features = Substitute.For<IFeatureCollection>();
        this.Request = Substitute.For<HttpRequest>();
        this.Response = Substitute.For<HttpResponse>();
        this.Connection = Substitute.For<ConnectionInfo>();
        this.User = Substitute.For<ClaimsPrincipal>();
        this.Items = Substitute.For<IDictionary<object, object?>>();
        this.RequestServices = Substitute.For<IServiceProvider>();
        this.TraceIdentifier = String.Empty;
        this.Session = Substitute.For<ISession>();
    }

    public MockHttpContext(
        WebSocketManager webSockets,
        IFeatureCollection features,
        HttpRequest request,
        HttpResponse response,
        ConnectionInfo connection,
        ClaimsPrincipal user,
        IDictionary<object, object?> items,
        IServiceProvider requestServices,
        string traceIdentifier,
        ISession session)
    {
        this.WebSockets = webSockets;
        this.Features = features;
        this.Request = request;
        this.Response = response;
        this.Connection = connection;
        this.User = user;
        this.Items = items;
        this.RequestServices = requestServices;
        this.TraceIdentifier = traceIdentifier;
        this.Session = session;
    }

    public override void Abort()
    {
        throw new NotImplementedException();
    }

    public override IFeatureCollection Features { get; }
    public override HttpRequest Request { get; }
    public override HttpResponse Response { get; }
    public override ConnectionInfo Connection { get; }
    public override WebSocketManager WebSockets { get; }
    public override ClaimsPrincipal User { get; set; }
    public override IDictionary<object, object?> Items { get; set; }
    public override IServiceProvider RequestServices { get; set; }
    public override CancellationToken RequestAborted { get; set; }
    public override string TraceIdentifier { get; set; }
    public override ISession Session { get; set; }
}
