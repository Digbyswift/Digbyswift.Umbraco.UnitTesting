using System;
using System.Collections.Generic;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockMediaTypeService : IMediaTypeService
{
    IContentTypeComposition? IContentTypeBaseService.Get(int id)
    {
        return this.Get(id);
    }

    public IMediaType? Get(Guid key)
    {
        throw new NotImplementedException();
    }

    public IMediaType? Get(string alias)
    {
        throw new NotImplementedException();
    }

    public int Count()
    {
        throw new NotImplementedException();
    }

    public bool HasContentNodes(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaType> GetAll(params int[] ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaType> GetAll(IEnumerable<Guid>? ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaType> GetDescendants(int id, bool andSelf)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaType> GetComposedOf(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaType> GetChildren(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMediaType> GetChildren(Guid id)
    {
        throw new NotImplementedException();
    }

    public bool HasChildren(int id)
    {
        throw new NotImplementedException();
    }

    public bool HasChildren(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Save(IMediaType? item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Save(IEnumerable<IMediaType> items, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Delete(IMediaType item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Delete(IEnumerable<IMediaType> item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<string[]?> ValidateComposition(IMediaType? compo)
    {
        throw new NotImplementedException();
    }

    public bool HasContainerInPath(string contentPath)
    {
        throw new NotImplementedException();
    }

    public bool HasContainerInPath(params int[] ids)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<OperationResultType, EntityContainer>?> CreateContainer(int parentContainerId, Guid key, string name, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult?> SaveContainer(EntityContainer container, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public EntityContainer? GetContainer(int containerId)
    {
        throw new NotImplementedException();
    }

    public EntityContainer? GetContainer(Guid containerId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EntityContainer> GetContainers(int[] containerIds)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EntityContainer> GetContainers(IMediaType contentType)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EntityContainer> GetContainers(string folderName, int level)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult?> DeleteContainer(int containerId, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<OperationResultType, EntityContainer>?> RenameContainer(int id, string name, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<MoveOperationStatusType>?> Move(IMediaType moving, int containerId)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<MoveOperationStatusType, IMediaType>?> Copy(IMediaType copying, int containerId)
    {
        throw new NotImplementedException();
    }

    public IMediaType Copy(IMediaType original, string alias, string name, int parentId = -1)
    {
        throw new NotImplementedException();
    }

    public IMediaType Copy(IMediaType original, string alias, string name, IMediaType parent)
    {
        throw new NotImplementedException();
    }

    public IMediaType? Get(int id)
    {
        throw new NotImplementedException();
    }
}