using System;
using System.Collections.Generic;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockMemberTypeService : IMemberTypeService
{
    IContentTypeComposition? IContentTypeBaseService.Get(int id)
    {
        return this.Get(id);
    }

    public IMemberType? Get(Guid key)
    {
        throw new NotImplementedException();
    }

    public IMemberType? Get(string alias)
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

    public IEnumerable<IMemberType> GetAll(params int[] ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMemberType> GetAll(IEnumerable<Guid>? ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMemberType> GetDescendants(int id, bool andSelf)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMemberType> GetComposedOf(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMemberType> GetChildren(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IMemberType> GetChildren(Guid id)
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

    public void Save(IMemberType? item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Save(IEnumerable<IMemberType> items, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Delete(IMemberType item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void Delete(IEnumerable<IMemberType> item, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<string[]?> ValidateComposition(IMemberType? compo)
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

    public IEnumerable<EntityContainer> GetContainers(IMemberType contentType)
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

    public Attempt<OperationResult<MoveOperationStatusType>?> Move(IMemberType moving, int containerId)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<MoveOperationStatusType, IMemberType>?> Copy(IMemberType copying, int containerId)
    {
        throw new NotImplementedException();
    }

    public IMemberType Copy(IMemberType original, string alias, string name, int parentId = -1)
    {
        throw new NotImplementedException();
    }

    public IMemberType Copy(IMemberType original, string alias, string name, IMemberType parent)
    {
        throw new NotImplementedException();
    }

    public string GetDefault()
    {
        throw new NotImplementedException();
    }

    public IMemberType? Get(int id)
    {
        throw new NotImplementedException();
    }
}