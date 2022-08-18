namespace SiteDownloader.Repositories.Interfaces;

public interface IFolderRepository
{
    string CreateFolder(string folderName);

    string ClearAndCreateBaseDownloadDirectory();
}
