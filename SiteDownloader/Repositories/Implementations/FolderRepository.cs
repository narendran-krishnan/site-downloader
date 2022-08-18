using SiteDownloader.Repositories.Interfaces;

namespace SiteDownloader.Repositories.Implementations;

public class FolderRepository : IFolderRepository
{
    private const string BaseDownloadDirectory = ".\\DownloadedSiteContent\\";

    public string CreateFolder(string folderName)
    {
        var folderPath = BaseDownloadDirectory + folderName;
        var isFolderAlreadyExists = Directory.Exists(folderPath);
        if (!isFolderAlreadyExists)
        {
            Directory.CreateDirectory(folderPath);
        }

        return folderPath;
    }
    
    public string ClearAndCreateBaseDownloadDirectory()
    {
        var isBaseDownloadFolderExists = Directory.Exists(BaseDownloadDirectory);
        if (isBaseDownloadFolderExists)
        {
            Directory.Delete(BaseDownloadDirectory, true);
        }

        Directory.CreateDirectory(BaseDownloadDirectory);

        return BaseDownloadDirectory;
    }
}
