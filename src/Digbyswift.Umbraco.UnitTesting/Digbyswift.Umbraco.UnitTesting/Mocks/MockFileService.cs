using System;
using System.Collections.Generic;
using System.IO;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;

namespace Digbyswift.Umbraco.UnitTesting.Mocks;

public class MockFileService : IFileService
{
    public IEnumerable<string> GetPartialViewSnippetNames(params string[] filterNames)
    {
        throw new NotImplementedException();
    }

    public void CreatePartialViewFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public void CreatePartialViewMacroFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public void DeletePartialViewFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public void DeletePartialViewMacroFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IPartialView> GetPartialViews(params string[] names)
    {
        throw new NotImplementedException();
    }

    public IPartialView? GetPartialView(string path)
    {
        throw new NotImplementedException();
    }

    public IPartialView? GetPartialViewMacro(string path)
    {
        throw new NotImplementedException();
    }

    public Attempt<IPartialView?> CreatePartialView(IPartialView partialView, string? snippetName = null, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public Attempt<IPartialView?> CreatePartialViewMacro(IPartialView partialView, string? snippetName = null, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public bool DeletePartialView(string path, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public bool DeletePartialViewMacro(string path, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public Attempt<IPartialView?> SavePartialView(IPartialView partialView, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public Attempt<IPartialView?> SavePartialViewMacro(IPartialView partialView, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public Stream GetPartialViewFileContentStream(string filepath)
    {
        throw new NotImplementedException();
    }

    public void SetPartialViewFileContent(string filepath, Stream content)
    {
        throw new NotImplementedException();
    }

    public long GetPartialViewFileSize(string filepath)
    {
        throw new NotImplementedException();
    }

    public Stream GetPartialViewMacroFileContentStream(string filepath)
    {
        throw new NotImplementedException();
    }

    public void SetPartialViewMacroFileContent(string filepath, Stream content)
    {
        throw new NotImplementedException();
    }

    public long GetPartialViewMacroFileSize(string filepath)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IStylesheet> GetStylesheets(params string[] paths)
    {
        throw new NotImplementedException();
    }

    public IStylesheet? GetStylesheet(string? path)
    {
        throw new NotImplementedException();
    }

    public void SaveStylesheet(IStylesheet? stylesheet, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public void DeleteStylesheet(string path, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public void CreateStyleSheetFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public void DeleteStyleSheetFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public Stream GetStylesheetFileContentStream(string filepath)
    {
        throw new NotImplementedException();
    }

    public void SetStylesheetFileContent(string filepath, Stream content)
    {
        throw new NotImplementedException();
    }

    public long GetStylesheetFileSize(string filepath)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IScript> GetScripts(params string[] names)
    {
        throw new NotImplementedException();
    }

    public IScript? GetScript(string? name)
    {
        throw new NotImplementedException();
    }

    public void SaveScript(IScript? script, int? userId)
    {
        throw new NotImplementedException();
    }

    public void DeleteScript(string path, int? userId = null)
    {
        throw new NotImplementedException();
    }

    public void CreateScriptFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public void DeleteScriptFolder(string folderPath)
    {
        throw new NotImplementedException();
    }

    public Stream GetScriptFileContentStream(string filepath)
    {
        throw new NotImplementedException();
    }

    public void SetScriptFileContent(string filepath, Stream content)
    {
        throw new NotImplementedException();
    }

    public long GetScriptFileSize(string filepath)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ITemplate> GetTemplates(params string[] aliases)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ITemplate> GetTemplates(int masterTemplateId)
    {
        throw new NotImplementedException();
    }

    public ITemplate? GetTemplate(string? alias)
    {
        throw new NotImplementedException();
    }

    public ITemplate? GetTemplate(int id)
    {
        throw new NotImplementedException();
    }

    public ITemplate? GetTemplate(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ITemplate> GetTemplateDescendants(int masterTemplateId)
    {
        throw new NotImplementedException();
    }

    public void SaveTemplate(ITemplate template, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Attempt<OperationResult<OperationResultType, ITemplate>?> CreateTemplateForContentType(string contentTypeAlias, string? contentTypeName, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public ITemplate CreateTemplateWithIdentity(string? name, string? alias, string? content, ITemplate? masterTemplate = null, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void DeleteTemplate(string alias, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public void SaveTemplate(IEnumerable<ITemplate> templates, int userId = -1)
    {
        throw new NotImplementedException();
    }

    public Stream GetTemplateFileContentStream(string filepath)
    {
        throw new NotImplementedException();
    }

    public void SetTemplateFileContent(string filepath, Stream content)
    {
        throw new NotImplementedException();
    }

    public long GetTemplateFileSize(string filepath)
    {
        throw new NotImplementedException();
    }

    public string GetPartialViewMacroSnippetContent(string snippetName)
    {
        throw new NotImplementedException();
    }

    public string GetPartialViewSnippetContent(string snippetName)
    {
        throw new NotImplementedException();
    }
}
