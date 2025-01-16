using System;
using System.Collections.Generic;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.Membership;
using Umbraco.Cms.Core.Persistence.Querying;
using Umbraco.Cms.Core.Services;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockUserService : IUserService
{
    public int GetCount(MemberCountType countType)
    {
        throw new NotImplementedException();
    }

    public bool Exists(string username)
    {
        throw new NotImplementedException();
    }

    public IUser CreateWithIdentity(string username, string email, string passwordValue, string memberTypeAlias)
    {
        throw new NotImplementedException();
    }

    public IUser CreateWithIdentity(string username, string email, string passwordValue, string memberTypeAlias, bool isApproved)
    {
        throw new NotImplementedException();
    }

    public IUser? GetByProviderKey(object id)
    {
        throw new NotImplementedException();
    }

    public IUser? GetByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public IUser? GetByUsername(string? username)
    {
        throw new NotImplementedException();
    }

    public void Delete(IUser membershipUser)
    {
        throw new NotImplementedException();
    }

    public void Save(IUser entity)
    {
        throw new NotImplementedException();
    }

    public void Save(IEnumerable<IUser> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> FindByEmail(string emailStringToMatch, long pageIndex, int pageSize, out long totalRecords, StringPropertyMatchType matchType = StringPropertyMatchType.StartsWith)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> FindByUsername(string login, long pageIndex, int pageSize, out long totalRecords, StringPropertyMatchType matchType = StringPropertyMatchType.StartsWith)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetAll(long pageIndex, int pageSize, out long totalRecords)
    {
        throw new NotImplementedException();
    }

    public IUser CreateUserWithIdentity(string username, string email)
    {
        throw new NotImplementedException();
    }

    public Guid CreateLoginSession(int userId, string requestingIpAddress)
    {
        throw new NotImplementedException();
    }

    public bool ValidateLoginSession(int userId, Guid sessionId)
    {
        throw new NotImplementedException();
    }

    public void ClearLoginSession(Guid sessionId)
    {
        throw new NotImplementedException();
    }

    public int ClearLoginSessions(int userId)
    {
        throw new NotImplementedException();
    }

    public IDictionary<UserState, int> GetUserStates()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetAll(long pageIndex, int pageSize, out long totalRecords, string orderBy, Direction orderDirection, UserState[]? userState = null, string[]? includeUserGroups = null, string[]? excludeUserGroups = null, IQuery<IUser>? filter = null)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetAll(long pageIndex, int pageSize, out long totalRecords, string orderBy, Direction orderDirection, UserState[]? userState = null, string[]? userGroups = null, string? filter = null)
    {
        throw new NotImplementedException();
    }

    public void Delete(IUser user, bool deletePermanently)
    {
        throw new NotImplementedException();
    }

    public IProfile? GetProfileById(int id)
    {
        throw new NotImplementedException();
    }

    public IProfile? GetProfileByUserName(string username)
    {
        throw new NotImplementedException();
    }

    public IUser? GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetUsersById(params int[]? ids)
    {
        throw new NotImplementedException();
    }

    public void DeleteSectionFromAllUserGroups(string sectionAlias)
    {
        throw new NotImplementedException();
    }

    public EntityPermissionCollection GetPermissions(IUser? user, params int[] nodeIds)
    {
        throw new NotImplementedException();
    }

    public EntityPermissionCollection GetPermissions(IUserGroup?[] groups, bool fallbackToDefaultPermissions, params int[] nodeIds)
    {
        throw new NotImplementedException();
    }

    public EntityPermissionSet GetPermissionsForPath(IUser? user, string? path)
    {
        throw new NotImplementedException();
    }

    public EntityPermissionSet GetPermissionsForPath(IUserGroup[] groups, string path, bool fallbackToDefaultPermissions = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceUserGroupPermissions(int groupId, IEnumerable<char>? permissions, params int[] entityIds)
    {
        throw new NotImplementedException();
    }

    public void AssignUserGroupPermission(int groupId, char permission, params int[] entityIds)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetAllInGroup(int? groupId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetAllNotInGroup(int groupId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUser> GetNextUsers(int id, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUserGroup> GetAllUserGroups(params int[] ids)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IUserGroup> GetUserGroupsByAlias(params string[] alias)
    {
        throw new NotImplementedException();
    }

    public IUserGroup? GetUserGroupByAlias(string name)
    {
        throw new NotImplementedException();
    }

    public IUserGroup? GetUserGroupById(int id)
    {
        throw new NotImplementedException();
    }

    public void Save(IUserGroup userGroup, int[]? userIds = null)
    {
        throw new NotImplementedException();
    }

    public void DeleteUserGroup(IUserGroup userGroup)
    {
        throw new NotImplementedException();
    }
}