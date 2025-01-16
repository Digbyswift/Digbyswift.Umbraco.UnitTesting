using System;
using System.Collections.Generic;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockContentTypeService : IContentTypeService
{
    IContentTypeComposition? IContentTypeBaseService.Get(int id)
    {
        return this.Get(id);
    }

    public IContentType? Get(Guid key)
    {
        throw new NotImplementedException();
    }

    public IContentType? Get(string alias)
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

    public IEnumerable<IContentType> GetAll(params int[] ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IContentType> GetAll(IEnumerable<Guid>? ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IContentType> GetDescendants(int id, bool andSelf)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IContentType> GetComposedOf(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IContentType> GetChildren(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IContentType> GetChildren(Guid id)
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

    public void Save(IContentType? item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Save(IEnumerable<IContentType> items, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Delete(IContentType item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Delete(IEnumerable<IContentType> item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<string[]?> ValidateComposition(IContentType? compo)
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

    public IEnumerable<EntityContainer> GetContainers(IContentType contentType)
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

    public Attempt<OperationResult<MoveOperationStatusType>?> Move(IContentType moving, int containerId)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<MoveOperationStatusType, IContentType>?> Copy(IContentType copying, int containerId)
    {
        throw new NotImplementedException();
    }

    public IContentType Copy(IContentType original, string alias, string name, int parentId = -1)
    {
        throw new NotImplementedException();
    }

    public IContentType Copy(IContentType original, string alias, string name, IContentType parent)
    {
        throw new NotImplementedException();
    }

    public IContentType? Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> GetAllPropertyTypeAliases()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> GetAllContentTypeAliases(params Guid[] objectTypes)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> GetAllContentTypeIds(string[] aliases)
    {
        throw new NotImplementedException();
    }
}